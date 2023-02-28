using NiceBike.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace NiceBike.ViewModels;

public class CartViewModel : INotifyPropertyChanged
{
    private ObservableCollection<OrderItem> _cartItems;
    public ObservableCollection<OrderItem> CartItems
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
        CartItems = new ObservableCollection<OrderItem>();
    }


    public event PropertyChangedEventHandler PropertyChanged;
    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
