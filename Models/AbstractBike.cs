using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiceBike.Models;

public abstract class AbstractBike
{
    public abstract int IdCounter { get; }
    
    public abstract string Description { get; }
    public abstract double Price { get; }
    public abstract int Id { get; set; }
    public abstract string Name { get; set; }
    public abstract string SizesAndColors { get; set; }
    public abstract string Image { get; set; }
}
