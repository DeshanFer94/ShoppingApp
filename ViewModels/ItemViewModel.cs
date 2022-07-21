using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Shopping_App.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_App.ViewModels
{
    public partial class ItemViewModel : ObservableObject
    {
        private IShoppingCartItemService _shoppingCartItemService;

        [ObservableProperty]
        private int _itemCode;

        [ObservableProperty]
        private string _name;

        [ObservableProperty]
        private double _price;

        [ObservableProperty]
        private string _description;

        [ObservableProperty]
        private string image;

        public ItemViewModel(IShoppingCartItemService shoppingCartItemService)
        {
            _shoppingCartItemService = shoppingCartItemService;
        }

        [RelayCommand]
        public async void GetItemDetail()
        {
            var itemInfo = await _shoppingCartItemService.GetItemDetails(ItemCode);

            Name = itemInfo.ItemName;
            Price = itemInfo.Price;
            Description = itemInfo.Description;
            Image = itemInfo.icon;
        }
    }
}
