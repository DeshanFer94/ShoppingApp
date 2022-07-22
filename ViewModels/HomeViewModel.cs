using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_App.ViewModels
{
    public partial class HomeViewModel : ObservableObject
    {
        INavigationService _navigationService;

        public HomeViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }
        [RelayCommand]
        public void AddItem()
        {
            _navigationService.CreateBuilder().AddSegment<AddItemViewModel>().Navigate();
        }
        [RelayCommand]
        public void GetItem()
        {
            _navigationService.NavigateAsync("GetItemsPage");
        }
    }
}
