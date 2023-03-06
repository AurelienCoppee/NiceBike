using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiceBike.Models;

public abstract class AbstractBike
{
    private string name;
    public string Name { get => name; set => name = value; }

}
