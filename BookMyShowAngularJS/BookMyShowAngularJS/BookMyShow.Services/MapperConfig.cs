using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DataModels = BookMyShow.Services.Models;
using CoreModels = BookMyShow.Models;

namespace BookMyShow.Services
{
    public static class MapperConfig
    {
        public static void Configure() {

            Mapper.CreateMap<DataModels.Movie, CoreModels.Movie>();
 
            Mapper.CreateMap<CoreModels.Theater, DataModels.Theater>();

            Mapper.CreateMap<DataModels.Theater, CoreModels.Theater>();

            Mapper.CreateMap<CoreModels.BookingInfo, DataModels.BookingInfo>();

            Mapper.CreateMap<DataModels.BookingInfo, CoreModels.BookingInfo>();

            Mapper.CreateMap<DataModels.Ticket, CoreModels.Ticket>();
        }

    }
}
