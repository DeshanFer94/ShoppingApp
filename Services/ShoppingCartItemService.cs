using Shopping_App.Models;
using Shopping_App.RestServices;
using Shopping_App.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_App.Services
{
    public class ShoppingCartItemService : IShoppingCartItemService
    {
        IShoppingCartApiService _shoppingCartApiService;

        public ShoppingCartItemService(IShoppingCartApiService shoppingCartApiService)
        {
            _shoppingCartApiService = shoppingCartApiService;
        }

        public async Task<ShoppingCartItem> GetItemDetails(int itemCode)
        {
            return await _shoppingCartApiService.GetItemDetails(itemCode);
            
        }
    }
}
