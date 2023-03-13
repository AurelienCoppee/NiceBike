using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NiceBike.Models
{
    public class CatalogBike : AbstractBikeDecorator
    {
        private static int _idCounter = 0;

        public int Id { get; set; }
        public string SizesAndColors { get; set; }
        public int BuiltStock { get; set; }
        public int PartStock { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }

        public ICommand LearnMoreCommand { get; set; }

        public CatalogBike
            (AbstractBike bike,
            string description,
            decimal price,
            string image,
            int builtStock,
            int partStock
        ) : base(bike)
        {
            this.Id = _idCounter++;

            LearnMoreCommand = new Command(OnLearnMore);

            this.Description = description;
            this.Price = price;
            this.Image = image;
            this.SizesAndColors = "Sizes: S, M, L, XL Colors: Red, Blue, Green";
            this.BuiltStock = builtStock;
            this.PartStock = partStock;
        }

        private void OnLearnMore()
        {
            // Implement the behavior of the Learn More button
        }

    }
}
