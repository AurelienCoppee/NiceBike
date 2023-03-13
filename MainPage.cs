using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;
using NiceBike;

public class MainPage : Shell {
    public MainPage() {
        // Ajoutez vos pages ici
        AddTab(new CatalogPage(), "Catalog");
    }

    private void AddTab(Page page, string title) {
        Items.Add(new ShellContent { Content = page, Title = title });
    }

}
