using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Shopping_App.Models;
using Shopping_App.Services;
using Shopping_App.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_App.ViewModels
{
    public partial class AddItemViewModel : ObservableObject
    {
        IItemsService _addItemService;
        IPageDialogService _pageDialogService;


        [ObservableProperty]
        private string _itemName;

        [ObservableProperty]
        private string _itemDescription;

        [ObservableProperty]
        private double _itemPrice;

        [ObservableProperty]
        private bool _isBusy;

        [RelayCommand]
        public async void SaveItem()
        {
            ShoppingCartItem shoppingCartItem;
            shoppingCartItem = new ShoppingCartItem();

            shoppingCartItem.ItemName = ItemName;
            shoppingCartItem.Description = ItemDescription;
            shoppingCartItem.Price = ItemPrice;

            IsBusy = true; 
            
           var response = await _addItemService.setItems(shoppingCartItem);

            //await Task.Delay(1000);

            IsBusy = false;
            
            _pageDialogService.DisplayAlertAsync("Item Added", $"Item {response.Value.Code} added", "OK");
           
            

        }

        public AddItemViewModel(IItemsService addItemsService, IPageDialogService pageDialogService)
        {
            _addItemService = addItemsService;
            _pageDialogService = pageDialogService;
        }
    }


}
