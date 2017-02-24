using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BookMyShow.Services.Interfaces;
using BookMyShow.Models;
using BookMyShow.Services;

namespace BookMyShow.Web.Controllers.Api
{
    [RoutePrefix("api/Home")]
    public class HomeController : ApiController
    {
        //private readonly IBookMyShowManager bookMyShowManager;
        //public HomeController(IBookMyShowManager bookMyShowManager)
        //{
        //    this.bookMyShowManager = bookMyShowManager;
        //}

        BookMyShowServices bookMyShowManager = new BookMyShowServices();

        [Route("Movies")]
        [HttpGet]
        public List<Movie> Get(DateTime date)
        {
            return bookMyShowManager.GetMovies(date);
        }

        [Route("Theaters/{id}")]
        [HttpGet]
        public List<Theater> Get([FromUri]int id)
        {
            return bookMyShowManager.GetTheaters(id);
        }

        //[Route("BookingInfo")]
        //[HttpPost]
        //public List<BookingInfo> Get(BookingInfo bookingInfo)
        //{
        //    return bookMyShowManager.GetBookedSeats(bookingInfo);
        //}

        [Route("BookSeats")]
        [HttpPost]
        public Ticket bookSeats(BookingInfo bookingInfo)
        {
            return new Ticket
            {

                Id = bookMyShowManager.BookSeats(bookingInfo)
            };
        }

        [Route("Ticket/{id}")]
        [HttpGet]
        public Ticket GetTicket([FromUri]int id)
        {
            return bookMyShowManager.GetTicketDetails(id);
        }

        [Route("SeatsInfo")]
        [HttpPost]
        public SeatsInfo SeatsInfo(BookingInfo bookingInfo)
        {

            return bookMyShowManager.GetSeatsInfo(bookingInfo);
        }


    }       
            
            
}
