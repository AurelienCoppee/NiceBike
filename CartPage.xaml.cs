using MySql.Data.MySqlClient;
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

    public void Order(object sender, EventArgs e) 
    {
        string email = "salut@gmail.com";
        int payStatus = 1;
        using MySqlConnection connection = new(App.db.connectionString);
        connection.Open();
        string queryString = "INSERT INTO bike_orders (email, pay_status) VALUES (@Email, @PayStatus)";
        using MySqlCommand command = new(queryString, connection);
        command.Parameters.AddWithValue("@Email", email);
        command.Parameters.AddWithValue("@PayStatus", payStatus);
        int rowsAffected = command.ExecuteNonQuery();
        System.Diagnostics.Debug.WriteLine(App.Cart.Items);
    }
}
