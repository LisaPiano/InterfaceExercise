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
            Console.WriteLine("The car speeds down the highway");
        }

        public void Honk()
        { 
            Console.WriteLine("The car Hooooonks!");
        }
        public void GetsGas()
        {
            Console.WriteLine("The car gets gas.");
        }
        public double Cost { get; set; }

        public string Name { get; set; }

        public string Logo { get; set; }


    }
}
