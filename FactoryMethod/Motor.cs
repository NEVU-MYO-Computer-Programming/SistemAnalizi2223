using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Motor : IFactory
    {
        public void Drive(int km)
        {
            Console.WriteLine(  $"Motor  {km}km gitti.");
        }
    }
}
