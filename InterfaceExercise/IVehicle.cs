using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        public void Drive();
        public void Honk();
        public void GetsGas();

        public double Cost { get; set; }
    }
}
