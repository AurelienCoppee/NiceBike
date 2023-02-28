using NiceBike.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using MySql.Data.MySqlClient;

namespace NiceBike
{
    public class CatalogViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<Bike> bikes;
        public ObservableCollection<Bike> Bikes
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
            Bikes = new ObservableCollection<Bike>
            {
                new Bike(
                    "Simple bike for city travels with all needed parts like mudguards and lights",
                    499.99M,
                    "City Bike",
                    "bike.jpg",
                    GetStockParts(),
                    GetStockBuilt()
                ),
                new Bike(
                    "A mountain bike with wider tires and more grooved, and adapted mudguards",
                    499.99M,
                    "Explorer Bike",
                    "bike.jpg",
                    GetStockParts(),
                    GetStockBuilt()
                ),
                new Bike(
                    "A mountain bike with reinforced frame, no luggage rack, mudguards or light",
                    499.99M,
                    "Adventure Bike",
                    "bike.jpg",
                    GetStockParts(),
                    GetStockBuilt()
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
        private int GetStockBuilt()
        {
            string connectionString = "server=pat.infolab.ecam.be;port=63314;database=NiceBike;user=admin;password=password;";

            MySqlConnection connection = new MySqlConnection(connectionString);

                connection.Open();
                Console.WriteLine("Connection successful!");

                string queryString = "SELECT COUNT(*) FROM bike_list WHERE config = 1";
                using (MySqlCommand command = new MySqlCommand(queryString, connection)) {
                        object result = command.ExecuteScalar();
                        int rowCount = Convert.ToInt32(result);
                        Console.WriteLine("Row count: " + rowCount);
                connection.Close();
                return rowCount;
            }
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
                int avQuentity = 20;//Query the db with the name of the part
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
