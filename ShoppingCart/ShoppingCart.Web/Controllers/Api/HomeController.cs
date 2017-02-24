using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ShoppingCart.Models;
using ShoppingCart.Services.Interfaces;
using ShoppingCart.Services;

namespace ShoppingCart.Web.Controllers.Api
{
    public class HomeController : ApiController
    {
        //private readonly IShoppingCartService shoppingCartService;
        //public HomeController(IShoppingCartService shoppingCartService)
        //{
        //    this.shoppingCartService = shoppingCartService;
        //}

        ShoppingCartService shoppingCartService = new ShoppingCartService();

       public List<Product> Get()
       {
         return shoppingCartService.GetProducts();
       }

       public List<Product> Get(string category, string brand)
       {
           return shoppingCartService.GetItems(category, brand);
       }

    }
}
