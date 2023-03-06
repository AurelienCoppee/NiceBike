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

    private void AddPart(object sender, EventArgs e)
    {
        var button = sender as Button;

        var Obj = button?.BindingContext as DbObject;
        Obj.update("stock", (Obj.stock + 1).ToString());

    }

    private void RemovePart(object sender, EventArgs e)
    {
        var button = sender as Button;

        var Obj = button?.BindingContext as DbObject;
        Obj.update("stock", (Obj.stock - 1).ToString());

    }



    private void RemoveBike(object sender, EventArgs e)
    {
        var button = sender as Button;

        var Obj = button?.BindingContext as DbObject;
        Obj.yeet();

    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        dbcvm.load();
    }
}
