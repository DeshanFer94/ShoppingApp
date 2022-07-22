using RestEase.HttpClientFactory;
using Shopping_App.RestServices;
using Shopping_App.Services;
using Shopping_App.Services.Abstractions;
using Shopping_App.ViewModels;
using Shopping_App.Views;

namespace Shopping_App;

public static class MauiProgram
{

	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UsePrismApp<App>(prism =>
			{
				prism.RegisterTypes(container =>
				{
					container.Register<IShoppingCartItemService, ShoppingCartItemService>();
					container.Register<IItemsService, ItemsService>();
					container.RegisterForNavigation<ItemView, ItemViewModel>();
					container.RegisterForNavigation<AddItemView, AddItemViewModel>();
                })
				.ConfigureServices(service =>
				{
					// service.AddRestEaseClient<IShoppingCartApiService>("http://sampleshopping.azurewebsites.net");
					service.AddRestEaseClient<IItemsAPIService>("http://sampleshopping.azurewebsites.net");
				})
                //.OnAppStart(navigation => navigation.CreateBuilder().AddNavigationPage().AddSegment<ItemViewModel>().Navigate());
                .OnAppStart(navigation => navigation.CreateBuilder().AddNavigationPage().AddSegment<AddItemViewModel>().Navigate());

            })
            .ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		return builder.Build();
	}
}
