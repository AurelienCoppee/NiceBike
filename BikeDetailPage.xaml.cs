namespace NiceBike;
using NiceBike.Models;
using System.Collections.ObjectModel;

public partial class BikeDetailPage : ContentPage
{
	public BikeDetailPage(ObservableCollection<Bike> bikes, int bikeId)
	{
		InitializeComponent();

        var bike = bikes.FirstOrDefault(b => b.Id == bikeId);
        if (bike != null)
        {
            // Populate the details of the selected bike in the Grid
            // ...
            BindingContext = bike;
        }
    }

    private void AddToCart(object sender, EventArgs e)
    {
        var button = sender as Button;
        var bike = button?.BindingContext as Bike;
        if (bike != null)
        {
            App.Cart.AddToCart(bike);
            Application.Current.MainPage.Navigation.PushAsync(new CartPage());
        }
    }

}