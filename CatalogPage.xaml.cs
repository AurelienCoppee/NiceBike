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
            
            var bike = button?.BindingContext as CatalogBike;
            if (bike != null)
            {
                App.Cart.AddToCart(bike);
                
                if (bike.BuiltStock > 0)
                {
                    bike.BuiltStock--;
                }
                else if (bike.PartStock > 0)
                {
                    bike.PartStock--;
                }
            }
            
        }
        private void GoToCart(object sender, EventArgs e)
        {
            Application.Current.MainPage.Navigation.PushAsync(new CartPage());
        }
        private void GoToStock(object sender, EventArgs e)
        {
            Application.Current.MainPage.Navigation.PushAsync(new DbPage());
        }

    }
}

