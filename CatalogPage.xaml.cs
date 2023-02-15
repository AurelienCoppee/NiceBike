/*namespace NiceBike;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

    private void OnCounterClicked(object sender, EventArgs e)
    {
        count++;

        if (count == 1)
            CounterBtn.Text = $"Clicked {count} time";
        else
            CounterBtn.Text = $"Clicked {count} times";

        SemanticScreenReader.Announce(CounterBtn.Text);
    }*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;
using NiceBike.Models;

namespace NiceBike
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CatalogPage : ContentPage
    {

        public CatalogPage()
        {
            InitializeComponent();

            BindingContext = new CatalogViewModel();
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
}

