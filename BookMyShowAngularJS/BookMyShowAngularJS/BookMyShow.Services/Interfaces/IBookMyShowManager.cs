using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookMyShow.Models;


namespace BookMyShow.Services.Interfaces
{
   public interface IBookMyShowManager
    {
        List<Movie> GetMovies(DateTime showDate);
        List<Theater> GetTheaters(int movieId);
        List<BookingInfo> GetBookedSeats(BookingInfo bookedSeats);
        int BookSeats(BookingInfo bookseats);
        Ticket GetTicketDetails(int ticketId);
        
    }
}
