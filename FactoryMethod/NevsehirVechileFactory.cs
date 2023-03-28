using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class NevsehirVechileFactory : CommonFactory
    {
        public override IFactory GetVehicle(string type)
        {
            switch (type)
            {

                case "Bike":
                case "bike":
                    return new Bike();

                case "Scooter":
                case "scooter":
                    return new Scooter();

                case "Motor":
                case "motor":
                    return new Motor();

                default: return null;

            }
        }
    }
}
