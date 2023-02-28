using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiceBike.Models;

public class BikeSize : AbstractBikeDecorator
{
    private string? size;
    public string? Size { get => size; set => size = value; }
    public BikeSize(AbstractBike bike, string? size) : base(bike)
    {
        this.size = size;
    }

}
