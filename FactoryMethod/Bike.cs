using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class Bike : IFactory
    {
        public void Drive(int km)
        {
            Console.WriteLine(  $"Bisiklet {km}km. gitti.");
        }
    }
}
