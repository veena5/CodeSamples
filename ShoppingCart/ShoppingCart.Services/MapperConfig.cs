using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DataModels = ShoppingCart.Services.Models;
using CoreModels = ShoppingCart.Models;

namespace ShoppingCart.Services
{
  public static class MapperConfig
    {
      public static void Configuration()
      {
          Mapper.Initialize(cfg => cfg.CreateMap<DataModels.Product, CoreModels.Product>());
      }
    }
}
