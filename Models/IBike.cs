using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiceBike
{
    public interface IBike
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string SizesAndColors { get; set; }
        public string Image { get; set; }

    }

}
