using NiceBike.Models;
using NiceBike.ViewModels;
using System.Collections.ObjectModel;

namespace NiceBike;

public partial class CartPage : ContentPage
{
    private CartViewModel _viewModel;

    public CartPage()
    {
        InitializeComponent();
        _viewModel = new CartViewModel();
        BindingContext = _viewModel;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        _viewModel.CartItems = new ObservableCollection<Bike>(App.Cart.Items);
    }
}
