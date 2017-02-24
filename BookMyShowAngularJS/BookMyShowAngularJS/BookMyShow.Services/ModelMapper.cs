using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BookMyShow.Services;
using DataModels = BookMyShow.Services.Models;
using CoreModels = BookMyShow.Models;

namespace BookMyShow.Services
{
    public static class ModelMapper   
    {
        public static TDestination Map<TDestination>(this object TSource)
        {  
              MapperConfig.Configure();
             return Mapper.Map<TDestination>(TSource);
        }

        public static TDestination MapCollection<TSource,TDestination>(this TSource source)
        {
              MapperConfig.Configure();
              return Mapper.Map<TSource, TDestination>(source);
         }
    }
}
