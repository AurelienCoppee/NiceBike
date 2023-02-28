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
        ObservableCollection<OrderItem> orderItems = new ObservableCollection<OrderItem>(App.Cart.Items);

        _viewModel.CartItems = orderItems;
    }
}
