using NiceBike.Models;
using NiceBike.ViewModels;
using System.Collections.ObjectModel;

namespace NiceBike;

public partial class DbPage : ContentPage
{
    public DataBaseControlViewModel dbcvm;
	public DbPage()
	{
		InitializeComponent();
        dbcvm = new DataBaseControlViewModel();
        BindingContext = dbcvm;
	}

    private void Add(object sender, EventArgs e)
    {
        var button = sender as Button;

        var Obj = button?.BindingContext as DbObject;
        Obj.update("stock", (Obj.stock + 1).ToString());

    }

    private void Remove(object sender, EventArgs e)
    {
        var button = sender as Button;

        var Obj = button?.BindingContext as DbObject;
        Obj.update("stock", (Obj.stock - 1).ToString());

    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        dbcvm.load();
    }
}
