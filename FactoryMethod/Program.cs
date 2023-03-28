using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CommonFactory factory = new NevsehirVechileFactory();

            IFactory bisiklet1 = factory.GetVehicle("bike");

            IFactory scooter1 = factory.GetVehicle("scooter");

            IFactory motor1 = factory.GetVehicle("motor");



            bisiklet1.Drive(10);
            scooter1.Drive(10);
            motor1.Drive(10);


            Console.Read();

        }
    }
}
