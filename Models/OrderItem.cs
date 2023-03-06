using System;
namespace NiceBike.Models
{
	public class OrderItem : AbstractBikeDecorator
	{
		private CatalogBike bike;

        public decimal Price { get; set; }

        private int qt;
        public OrderItem(CatalogBike sBike, int sQt) : base(sBike)
        {
            bike = (CatalogBike)sBike;
            this.Price = sBike.Price;
            qt = sQt;
        }
		public void add(int aQt)
		{
			qt += aQt;
			Price = qt * bike.Price;
		}
		public void remove(int rQt)
		{
			qt -= rQt;
			if (qt < 0)
			{
				qt = 0;
			}
            Price = qt * bike.Price;
        }
		public CatalogBike GetBike()
		{
			return bike;
		}
	}
}

