using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetaPoco;
using AutoMapper;
using ShoppingCart.Services.Interfaces;
using CoreModels=ShoppingCart.Models;
using DataModels=ShoppingCart.Services.Models;
namespace ShoppingCart.Services
{
    public class ShoppingCartService:IShoppingCartService
    {

        public List<CoreModels.Product> GetProducts()
        {
            using (var database = new Database("ShoppingCart"))
            {
                return database.Fetch<DataModels.Product>("Select * from Products").MapCollection<List<DataModels.Product>, List<CoreModels.Product>>(); 
                 
             }
        }

        public List<CoreModels.Product> GetItems(string category,string brand)
        {
            using (var database = new Database("ShoppingCart"))
            {
                return database.Fetch<DataModels.Product>("select * from Products where Category=@0 AND Brand=@1", category, brand).MapCollection<List<DataModels.Product>, List<CoreModels.Product>>();
            }
        }

    }
}
