using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class Truck
    {
        public int cargo_volume;
        public string color;
        public string brand;

        public Truck(int Acargo_volume, string Acolor, string Abrand)
        {
            cargo_volume = Acargo_volume;
            color = Acolor;
            brand = Abrand;
        }
    }
}
