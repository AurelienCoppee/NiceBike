using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiceBike.Models;

public abstract class AbstractBikeDecorator : AbstractBike
{
    protected readonly AbstractBike _bike;
    public AbstractBikeDecorator(AbstractBike bike)
    {
        _bike = bike;
    }
}
