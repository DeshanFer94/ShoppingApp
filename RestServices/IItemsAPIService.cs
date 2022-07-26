﻿using RestEase;
using Shopping_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_App.RestServices
{
    [Header("User-Agent", "RestEase")]
    public interface IItemsAPIService
    {
        [Post("/Item/AddItem")]

        Task<ResponseBase<ShoppingCartItem>> setItemDetails([Body] ShoppingCartItem shoppingCartItem);

        [Get("/Item/Get")]
        Task<ResponseBase<List<ShoppingCartItem>>> GetItemList();

        [Get("/Item/DeleteItem/{ItemCode}")]
        Task<ResponseBase<int>> DeleteItem([Path] int ItemCode);

    }
}
