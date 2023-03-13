using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiceBike.Models;

public class Cart
{
    private List<OrderItem> _items;

    public Cart()
    {
        _items = new List<OrderItem>();
    }

    public void AddToCart(CatalogBike bike)
    {
        OrderItem item = FindOrderItem(bike);

        if (item == null)
        {
            item = new OrderItem(bike, 1);
            _items.Add(item);
        }
        else
        {
            item.add(1);
        }


    }

    public void RemoveFromCart(CatalogBike bike)
    {
        OrderItem item = FindOrderItem(bike);
        if (item == null)
        {
            return;
        }
        _items.Remove(item);
    }
    public void RemoveSomeFromCart(CatalogBike bike, int qt)
    {
        OrderItem item = FindOrderItem(bike);
        item?.remove(qt);
    }

    public void ClearCart()
    {
        _items.Clear();
    }

    public IReadOnlyList<OrderItem> Items
    {
        get { return _items.AsReadOnly(); }
    }

    public decimal TotalPrice
    {
        get { return _items.Sum(o => o.GetBike().Price); }
    }
    private OrderItem FindOrderItem(CatalogBike bike)
    {
        foreach (OrderItem item in _items)
        {
            if (item.GetBike() == bike)
            {
                return item;
            }

        }
        return null;
    }
}