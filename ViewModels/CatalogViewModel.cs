using NiceBike.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using MySql.Data.MySqlClient;
using TestNiceBike.Models;

namespace NiceBike
{
    public class CatalogViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<CatalogBike> bikes;
        public ObservableCollection<CatalogBike> Bikes
        {
            get { return bikes; }
            set
            {
                bikes = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Bikes)));
            }
        }

        public CatalogViewModel()
        {
            // Initialize the Bikes collection with some sample data
            Bikes = new ObservableCollection<CatalogBike>
            {
                    new CatalogBike(
        new Bike("City"),
        App.db.GetColumnValueByPrimaryKey("bike_model","name","City","description"),
        decimal.Parse(App.db.GetColumnValueByPrimaryKey("bike_model","name","City","price")),
        App.db.GetColumnValueByPrimaryKey("bike_model","name","City","image"),
        GetStockParts(),
        GetStockBuilt("City")
    ),
    new CatalogBike(
        new Bike("Explorer"),
        App.db.GetColumnValueByPrimaryKey("bike_model","name","Explorer","description"),
        decimal.Parse(App.db.GetColumnValueByPrimaryKey("bike_model","name","Explorer","price")),
        App.db.GetColumnValueByPrimaryKey("bike_model","name","Explorer","image"),
        GetStockParts(),
        GetStockBuilt("Explorer")
    ),
    new CatalogBike(
        new Bike("Adventure"),
        App.db.GetColumnValueByPrimaryKey("bike_model","name","Adventure","description"),
        decimal.Parse(App.db.GetColumnValueByPrimaryKey("bike_model","name","Adventure","price")),
        App.db.GetColumnValueByPrimaryKey("bike_model", "name", "Adventure", "image"),
        GetStockParts(),
        GetStockBuilt("Adventure")
    )
            };

            foreach (var bike in Bikes)
            {
                bike.LearnMoreCommand = new Command(async () =>
                {
                    await Application.Current.MainPage.Navigation.PushAsync(new BikeDetailPage(Bikes, bike.Id));
                });
            }
        }
        private int GetStockBuilt(String name)
        {
            return App.db.NumberOfRowsWithValue("bike_list", "model", name);
        }
        private int GetStockParts()
        {
            List<(string,int)> partList = new List<(string,int)>
            {
                ("frame",1),
                ("tire",2),
                ("handlebar",1),
                ("screw",12)
            };
            int leastBuildable = 1000000;
            foreach ((string, int) part in partList)
            {
                int avQuentity = App.db.NumberOfRowsWithValue("parts", "name", part.Item1);
                avQuentity = avQuentity / part.Item2;
                if (avQuentity< leastBuildable)
                {
                    leastBuildable = avQuentity;
                }
            }
            return leastBuildable;
        }
    }
}
