using NiceBike.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;

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
                new Bike { Name = "City Bike", Description = "Simple bike for city travels with all needed parts like mudguards and lights", Price = 499.99M, SizesAndColors = "Available in sizes 26\" and 28\", in blue or red", Image = "bike.jpg" ,PartStock = GetStockParts(),BuiltStock = GetStockBuilt()},
                new Bike { Name = "Explorer Bike", Description = "A mountain bike with wider tires and more grooved, and adapted mudguards", Price = 699.99M, SizesAndColors = "Available in sizes 26\" and 28\", in green or black", Image = "bike.jpg",PartStock = GetStockParts() ,BuiltStock = GetStockBuilt()},
                new Bike { Name = "Adventure Bike", Description = "A mountain bike with reinforced frame, no luggage rack, mudguards or light", Price = 799.99M, SizesAndColors = "Available in sizes 26\" and 28\", in yellow or orange", Image = "bike.jpg",PartStock = GetStockParts() ,BuiltStock = GetStockBuilt()}
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
            //Query the db with the name of the part
            return 5;
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
