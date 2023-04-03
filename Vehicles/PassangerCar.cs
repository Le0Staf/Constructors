using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class PassangerCar
    {
        public int trunk_volume;
        public string color;
        public string brand;

        public PassangerCar(int Atrunk_volume, string Acolor, string Abrand)
        {
            trunk_volume = Atrunk_volume;
            color = Acolor;
            brand = Abrand;
        }
    }
}
