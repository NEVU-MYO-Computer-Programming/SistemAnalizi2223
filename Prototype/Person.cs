using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Person
    {
        public int Age { get; set; }//Property - Özellik
        public string Name { get; set; }
        public IdData IdInfo { get; set; }

        public Person ShallowCopy()
        {
            return (Person)this.MemberwiseClone();
        }

        public Person DeepCopy()
        {
            Person clone = ShallowCopy();
            clone.Name = String.Copy(this.Name);
            clone.IdInfo = new IdData(this.IdInfo.IdNumber);
            return clone;
        }


        public override string ToString()
        {
            var metin = string.Format(" ad : {0} , yaş : {1} , id:{2} ", this.Name, this.Age, this.IdInfo.IdNumber);

            return metin;
        }


    }
}
