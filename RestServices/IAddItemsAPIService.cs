using RestEase;
using Shopping_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_App.RestServices
{
    [Header("User-Agent", "RestEase")]
    public interface IAddItemsAPIService
    {
        [Post("/Item/AddItem")]

        Task<ResponseBase<ShoppingCartItem>> setItemDetails([Body] ShoppingCartItem shoppingCartItem);
    }
}
