using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNamespace
{
    public interface IVehicle{
        string Name { get; set; }
        double HorsePower{ get; set; }
        double Chassis { get; set; }

        void Display();

       
    }

}
