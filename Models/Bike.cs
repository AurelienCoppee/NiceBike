using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NiceBike.Models
{
    public class Bike
    {
        private static int _idCounter = 0;

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string SizesAndColors { get; set; }
        public string Image { get; set; }
        public int BuiltStock { get; set; }
        public int PartStock { get; set; }

        public ICommand LearnMoreCommand { get; set; }

        public Bike()
        {
            Id = _idCounter++;
            LearnMoreCommand = new Command(OnLearnMore);
        }

        private void OnLearnMore()
        {
            // Implement the behavior of the Learn More button
        }

    }
}
