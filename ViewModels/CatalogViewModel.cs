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
                new Bike { Name = "City Bike", Description = "Simple bike for city travels with all needed parts like mudguards and lights", Price = 499.99M, SizesAndColors = "Available in sizes 26\" and 28\", in blue or red", Image = "test.jpg" },
                new Bike { Name = "Explorer Bike", Description = "A mountain bike with wider tires and more grooved, and adapted mudguards", Price = 699.99M, SizesAndColors = "Available in sizes 26\" and 28\", in green or black", Image = "test.jpg" },
                new Bike { Name = "Adventure Bike", Description = "A mountain bike with reinforced frame, no luggage rack, mudguards or light", Price = 799.99M, SizesAndColors = "Available in sizes 26\" and 28\", in yellow or orange", Image = "test.jpg" }
            };

            foreach (var bike in Bikes)
            {
                bike.LearnMoreCommand = new Command(async () =>
                {
                    await Application.Current.MainPage.Navigation.PushAsync(new BikeDetailPage(Bikes, bike.Id));
                });
            }
        }
    }
}
