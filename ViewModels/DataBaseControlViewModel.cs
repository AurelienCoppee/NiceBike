﻿using System.ComponentModel;
using System.Runtime.CompilerServices;
using NiceBike.Models;
using System.Collections.ObjectModel;


namespace NiceBike.ViewModels;

public class DataBaseControlViewModel : ContentPage
{
    public ObservableCollection<DbObject> bikes;


    public DataBaseControlViewModel()
	{
        bikes = new ObservableCollection<DbObject>();
    }
    
    public new  event PropertyChangedEventHandler  PropertyChanged;
    protected new virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}

