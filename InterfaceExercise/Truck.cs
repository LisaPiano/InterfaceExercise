using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Truck
    {
        public void Drive()
        {
            Console.WriteLine($"The {GetType().Name} drives with a tremendous power");
        }

        public void Honk()
        {
            Console.WriteLine($"The {GetType().Name} says Woooo Woooo!");
        }
        public void GetsGas()
        {
            Console.WriteLine($"The {GetType().Name} never needs gas because it is an electric truck.");
        }
        public double Cost { get; set; }

        public string Name { get; set; }

        public string Logo { get; set; }

        public bool AWD { get; set; } = true;

        public bool CanTow { get; set; } = false;
    }
}
