using RestEase;
using Shopping_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_App.Services.Abstractions
{
    public interface IShoppingCartItemService
    {
        Task<ShoppingCartItem> GetItemDetails(int itemCode);
    }
}
