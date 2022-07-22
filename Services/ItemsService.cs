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
    public class ItemsService : IItemsService
    {
        IItemsAPIService _addItemsAPIService;
        
       
       public async Task<ResponseBase<ShoppingCartItem>> setItems(ShoppingCartItem shoppingCartItem)
        {
          return await _addItemsAPIService.setItemDetails(shoppingCartItem);

                    
        }

        public async Task<ResponseBase<List<ShoppingCartItem>>> GetItemList()
        {
            return await _addItemsAPIService.GetItemList();
        }

        public ItemsService(IItemsAPIService addItemsAPISevice)
        {
            _addItemsAPIService = addItemsAPISevice;
        }

        
    }
}
