using System.ComponentModel;
using System.Runtime.CompilerServices;
using NiceBike.Models;
using System.Collections.ObjectModel;


namespace NiceBike.ViewModels;

public class DataBaseControlViewModel : INotifyPropertyChanged
{
    private ObservableCollection<DbObject> _bikes;
    public ObservableCollection<DbObject> bikes
    {
        get { return _bikes; }
        set
        {
            _bikes = value;
            OnPropertyChanged();
        }
    }
    private ObservableCollection<DbObject> _bikeParts;
    public ObservableCollection<DbObject> bikeParts
    {
        get { return _bikeParts; }
        set
        {
            _bikeParts = value;
            OnPropertyChanged();
        }
    }
    
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
    
    public   event PropertyChangedEventHandler  PropertyChanged;
    protected  virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}

