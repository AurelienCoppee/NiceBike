using NiceBike.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace NiceBike.ViewModels;

public class CartViewModel : INotifyPropertyChanged
{
    private ObservableCollection<Bike> _cartItems;
    public ObservableCollection<Bike> CartItems
    {
        get { return _cartItems; }
        set
        {
            _cartItems = value;
            OnPropertyChanged();
        }
    }

    public CartViewModel()
    {
        CartItems = new ObservableCollection<Bike>();
    }

    public void AddToCart(Bike bike)
    {
        CartItems.Add(bike);
    }

    public event PropertyChangedEventHandler PropertyChanged;
    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
