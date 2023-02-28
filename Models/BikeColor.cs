using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiceBike.Models;

public class BikeColor : AbstractBikeDecorator
{
    private string? color;
    public string? Color { get => color; set => color = value; }
    public BikeColor(AbstractBike bike, string? color) : base(bike)
    {
        this.color = color;
    }
}
