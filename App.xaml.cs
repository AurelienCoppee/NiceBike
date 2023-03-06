using NiceBike.Models;

namespace NiceBike;

public partial class App : Application
{
    
	public static Database db = new();
    public static Cart Cart { get; } = new Cart();
    public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
        db.OpenConnection();
    }
}
