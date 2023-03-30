using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class SUV
    {
        public void Drive()
        {
            Console.WriteLine($"The {GetType().Name} is bumpy on the road");
        }

        public void Honk()
        {
            Console.WriteLine($"The {GetType().Name} sings a silly song.");
        }
        public void GetsGas()
        {
            Console.WriteLine($"The {GetType().Name} spends way too much money getting gas.");
        }
        public double Cost { get; set; }

        public string Name { get; set; }

        public string Logo { get; set; }

        public int NumberOfRows { get; set; }

        public bool VisualReverse { get; set; } = true;

        public int NumberOfFloormats { get; set; } = 4;
    }
}
