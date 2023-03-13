using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;
using NiceBike;

public class MainPage : TabbedPage
{
    public MainPage() {
        Children.Add(new CatalogPage());
    }

}