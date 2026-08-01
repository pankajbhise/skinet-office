using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Core.Interfaces
{
    public interface ICartService
    {
        Task<ShoppingCart?> GetCartAsync(string key);
        Task<ShoppingCart?> SetCartAsync(ShoppingCart? cart);
        Task<bool> DeleteCartAsync(string key);
 
    }
}
