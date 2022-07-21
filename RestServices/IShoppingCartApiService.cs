using RestEase;
using Shopping_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_App.RestServices
{
    
    public interface IShoppingCartApiService
    {
        [Get("/GetItem/{itemCode}")]
        Task<ShoppingCartItem> GetItemDetails([Path] int itemCode);
    }
}
