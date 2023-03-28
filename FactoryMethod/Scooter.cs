using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class Scooter : IFactory
    {
        public void Drive(int km)
        {
            Console.WriteLine($"Scooter {km}km gitti.");
        }
    }
}
