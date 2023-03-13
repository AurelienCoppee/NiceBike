using NiceBike.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNiceBike.Models;

internal class Bike : AbstractBike
{
    public Bike(string name)
    {
        Name = name;
    }
}
