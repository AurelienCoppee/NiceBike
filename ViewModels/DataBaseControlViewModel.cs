using System.ComponentModel;
using System.Runtime.CompilerServices;
using NiceBike.Models;
using System.Collections.ObjectModel;


namespace NiceBike.ViewModels;

public class DataBaseControlViewModel : ContentPage
{
    public ObservableCollection<DbObject> bikes;
    public ObservableCollection<DbObject> bikeParts;
    public DbController dbc;


    public DataBaseControlViewModel()
	{
        bikes = new ObservableCollection<DbObject>();
        bikeParts = new ObservableCollection<DbObject>();
        dbc = new DbController();
    }
    public void load()
    {
        dbc.load();
        dbc.list();
        bikes = dbc.bikes;
        bikeParts = dbc.bikeParts;
    }
    
    public new  event PropertyChangedEventHandler  PropertyChanged;
    protected new virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}

