using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace ShoppingCart.Services
{
    public static class AutoMapper
    {
        public static TDestination Map<TDestination>(this object TSource)
         {
             MapperConfig.Configuration();
             return Mapper.Map<TDestination>(TSource);
         }

        public static TDestination MapCollection<TSource,TDestination>(this TSource source)
        {
            MapperConfig.Configuration();
            return Mapper.Map<TSource,TDestination>(source);
        }
    }
}
