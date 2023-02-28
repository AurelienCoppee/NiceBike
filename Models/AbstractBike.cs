using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiceBike.Models;

public abstract class AbstractBike
{
    private string description;
    private decimal price;
    private string name;
    private string image;
    private string sizesAndColors;
    public string Description { get => description; set => description = value; }
    public decimal Price { get => price; set => price = value; }
    public string Name { get => name; set => name = value; }
    public string Image { get => image; set => image = value; }
    public string SizesAndColors { get => sizesAndColors; set => sizesAndColors = value; }

}
