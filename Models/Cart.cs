using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiceBike.Models
{
    public class Cart
    {
        private List<Bike> _items;

        public Cart()
        {
            _items = new List<Bike>();
        }

        public void AddToCart(Bike bike)
        {
            _items.Add(bike);
        }

        public void RemoveFromCart(Bike bike)
        {
            _items.Remove(bike);
        }

        public void ClearCart()
        {
            _items.Clear();
        }

        public IReadOnlyList<Bike> Items
        {
            get { return _items.AsReadOnly(); }
        }

        public decimal TotalPrice
        {
            get { return _items.Sum(b => b.Price); }
        }
    }

}
