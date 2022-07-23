using Prism.Behaviors;

namespace Shopping_App.Views;

public partial class GetItemView : ContentPage
{
	public GetItemView()
	{
        EventToCommandBehavior

        InitializeComponent();
	}

	private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
	{

	}
}