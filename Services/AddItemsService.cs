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
    public class AddItemsService : IAddItemsService
    {
        IAddItemsAPIService _addItemsAPIService;
        
       
       public async Task<ResponseBase<ShoppingCartItem>> setItems(ShoppingCartItem shoppingCartItem)
        {
          return await _addItemsAPIService.setItemDetails(shoppingCartItem);

                    
        }
        public AddItemsService(IAddItemsAPIService addItemsAPISevice)
        {
            _addItemsAPIService = addItemsAPISevice;
        }
    }
}
