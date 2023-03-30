using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public void Drive()
        {
            Console.WriteLine($"The {GetType().Name} speeds down the highway");
        }

        public void Honk()
        { 
            Console.WriteLine($"The {GetType().Name} Hooooonks!");
        }
        public void GetsGas()
        {
            Console.WriteLine($"The {GetType().Name} gets gas.");
        }
        public double Cost { get; set; }

        public string Name { get; set; }

        public string Logo { get; set; }

        public string TrunkSize { get; set; }

        public int NumberOfDoors { get; set; } = 4;

        public bool HasAWheel { get; set; } = true;

    }
}
