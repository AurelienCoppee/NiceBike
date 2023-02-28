﻿using System;
namespace NiceBike.Models
{
	public class OrderItem : AbstractBike
	{
		private Bike bike;

        private int qt;
		public OrderItem(Bike sBike, int sQt)
		{
			bike = sBike;
			Name = bike.Name;
			Description = bike.Description;
			Price = bike.Price;
			SizesAndColors = bike.SizesAndColors;
			Image = bike.Image;
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
		public Bike GetBike()
		{
			return bike;
		}
	}
}

