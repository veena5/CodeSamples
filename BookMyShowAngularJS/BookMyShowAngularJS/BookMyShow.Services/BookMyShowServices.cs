using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModels = BookMyShow.Services.Models;
using CoreModels = BookMyShow.Models;
using PetaPoco;
using AutoMapper;
using BookMyShow.Services.Interfaces;


namespace BookMyShow.Services
{
    public class BookMyShowServices:IBookMyShowManager
    {
        
        public List<CoreModels.Movie> GetMovies(DateTime showDate)
        {
            using (var database = new Database("BookMyShow"))
            {
                return database.Fetch<DataModels.Movie>("Select * from Movies where StartDate<=@0 AND EndDate>=@0", showDate.Date).MapCollection<List<DataModels.Movie>,List<CoreModels.Movie>>();
            }
        }
         
        public List<CoreModels.Theater> GetTheaters(int movieId)
        {
            using (var database = new Database("BookMyShow"))
            {
                return database.Fetch<DataModels.Theater>("Select * from Theaters where MoviePlaying=@0",movieId).MapCollection<List<DataModels.Theater>,List<CoreModels.Theater>>();
            }
        }

        public List<CoreModels.BookingInfo> GetBookedSeats(CoreModels.BookingInfo bookingInfo)
        {
            DataModels.BookingInfo dMbookingInfo = bookingInfo.Map<DataModels.BookingInfo>();
            using (var database = new Database("BookMyShow"))
            {
                return database.Fetch<DataModels.BookingInfo>("Select * from BookingInfo where MovieId=@0 AND TheaterId=@1 AND ShowDate=@2 AND ShowTime=@3", dMbookingInfo.MovieId, dMbookingInfo.TheaterId, dMbookingInfo.ShowDate, dMbookingInfo.ShowTime).MapCollection<List<DataModels.BookingInfo>,List<CoreModels.BookingInfo>>();
            }
        }

        public int BookSeats(CoreModels.BookingInfo bookSeats)
        {
          using (var database = new Database("BookMyShow"))
            {
              return Convert.ToInt16(database.Insert("BookingInfo", "Id", bookSeats.Map<DataModels.BookingInfo>()));
               
            }
        }

        public CoreModels.Ticket GetTicketDetails(int ticketId)
        {
           using (var database = new Database("bookMyShow"))
            {
                return (database.FirstOrDefault<DataModels.Ticket>("SELECT MovieName,TheaterName,ShowDate,ShowTime,SeatsBooked from ticket where TicketId=@0 ",ticketId)).Map<CoreModels.Ticket>();
            }
        }

        public CoreModels.SeatsInfo GetSeatsInfo(CoreModels.BookingInfo bookingInfo)
        {
            List<CoreModels.BookingInfo> bookedSeats = GetBookedSeats(bookingInfo);
            CoreModels.SeatsInfo seatsInfo = new CoreModels.SeatsInfo();
            seatsInfo.PremiumSeats = new List<CoreModels.Seat>();
            seatsInfo.StandardSeats = new List<CoreModels.Seat>();
            CoreModels.Theater theater;
            List<string> unavailableSeats= new List<string>() ; 
            foreach(var bookedSeat in bookedSeats)
            {
                var seats = bookedSeat.SeatsBooked.Split(',');
                unavailableSeats.AddRange(seats);
            }
            using( var database = new Database("bookMyShow"))
            {
               theater = database.FirstOrDefault<DataModels.Theater>("select * from Theaters where Id=@0",bookingInfo.TheaterId).Map<CoreModels.Theater>();
            }
            seatsInfo.NoOfPremiumRows = theater.NoOfPremiumRows;
            seatsInfo.NoOfStandardRows = theater.NoOfStandardRows;
         
            char row='A';
 
           seatsInfo.PremiumSeats = CreateSeats(row,theater.NoOfPremiumRows,theater.NoOfSeatsPerRow,unavailableSeats);
            row = Convert.ToChar('A'+theater.NoOfPremiumRows);
            seatsInfo.StandardSeats=CreateSeats(row,theater.NoOfStandardRows,theater.NoOfSeatsPerRow,unavailableSeats);

            return seatsInfo;
        }

        
        public List<CoreModels.Seat> CreateSeats(char row,int noOfRows,int noOfSeats,List<string> unavailableSeats)
        {
            List<CoreModels.Seat> seats = new List<CoreModels.Seat>();
            for (int i = 0; i < noOfRows; i++)
            {
                for (int j = 1; j <= (noOfSeats+1); j++)
                {
                    string seatId = row + "-" + j;
                    if (unavailableSeats.IndexOf(seatId) >= 0)
                    {
                        seats.Add(new CoreModels.Seat
                        {
                            Id = seatId,
                            Status = CoreModels.Enums.SeatStatus.Booked,
                            ImageUrl = "Content/Images/disbledChair.png"
                        });
                    }
                    else if (j == (noOfSeats+1))
                    {
                        seats.Add(new CoreModels.Seat
                        {
                            Id = seatId,
                            Status = CoreModels.Enums.SeatStatus.Booked,
                            ImageUrl = ""
                        });
                    }
                    else
                    {
                        seats.Add(new CoreModels.Seat
                        {
                            Id = seatId,
                            Status = CoreModels.Enums.SeatStatus.Available,
                            ImageUrl = "Content/Images/chair1.png"
                        });
                    }
                }
                row++;
              }
            return seats;
          }
        
    }
}
