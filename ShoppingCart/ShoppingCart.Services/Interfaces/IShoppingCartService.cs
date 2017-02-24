using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingCart.Models;

namespace ShoppingCart.Services.Interfaces
{
   public interface IShoppingCartService
    {
        List<Product> GetProducts();
        List<Product> GetItems(string category,string brand);
    }
    
}
