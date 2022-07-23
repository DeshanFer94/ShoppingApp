using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Prism.Navigation;
using Shopping_App.Models;
using Shopping_App.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_App.ViewModels
{
    public partial class GetItemsViewModel : ObservableObject, INavigationAware
    {
        private INavigationService _navigationService;
        public IItemsService _itemsService;
        [ObservableProperty]
        public ObservableCollection<ShoppingCartItem> _items = new ObservableCollection<ShoppingCartItem>();

        [ObservableProperty]
        private string _name;
        [ObservableProperty]
        private double _price;
        [ObservableProperty]
        public string _description;

       public GetItemsViewModel(IItemsService itemsService)
       {
            this._itemsService = itemsService;
       }

       public async void GetItemDetails()
         {
            
            var response = await _itemsService.GetItemList();
            Items = new ObservableCollection<ShoppingCartItem>(response.Value);

         }

        [RelayCommand]
        public void DeleteItem(ShoppingCartItem item)
        {

        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
            
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            GetItemDetails();
        }
        //public GetItemsViewModel(INavigationService navigationService)
        //{
        //    _navigationService = navigationService;
        //    Items.Add(new ShoppingCartItem { ItemName = "Soap", Price = 200, Description = "Baby Soap" });
        //    Items.Add(new ShoppingCartItem { ItemName = "Oil", Price = 800, Description = "Olive Soap" });
        //    Items.Add(new ShoppingCartItem { ItemName = "Chocolate", Price = 200, Description = "DArk Chocolate" });
        //}

    }
}
