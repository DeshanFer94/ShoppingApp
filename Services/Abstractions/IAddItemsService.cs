﻿using Shopping_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_App.Services.Abstractions
{
    public interface IAddItemsService
    {
        Task<ResponseBase<ShoppingCartItem>> setItems(ShoppingCartItem shoppingCartItem);
    }
}
