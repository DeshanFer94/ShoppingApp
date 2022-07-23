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
    public partial class DeleteItemViewModel : ObservableObject 
    {
        IItemsService _itemService;
        IPageDialogService _pageDialogService;
        INavigationService _navigationService;

        [ObservableProperty]
        private int _itemCode;

        [RelayCommand]
        public async void DeleteItem()
        {
           var response = await _itemService.DeleteItem(ItemCode);
         await _pageDialogService.DisplayAlertAsync("Item Delete", $"Item {response.Value} Deleted", "OK");
            _navigationService.GoBackAsync();

        }

        public DeleteItemViewModel(IItemsService itemsService, IPageDialogService pageDialogService, INavigationService navigationService)
        {
            _itemService= itemsService;
            _pageDialogService= pageDialogService;
            _navigationService= navigationService;
        }


    }
}
