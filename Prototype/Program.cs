using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Age = 20;
            p1.Name = "Ahmet";
            Person p2 = p1;//kopyalama olmadı, referans eşitlendi iki değişken de aynı nesneyi işaret eder.

            p1.IdInfo = new IdData(15);
            /********************************/
            Console.WriteLine("p1 : "+  p1.ToString());
            Console.WriteLine("p2 : " + p2.ToString());

            Person p3 = p1.ShallowCopy();
            Person p4 = p1.DeepCopy();
            Console.WriteLine(  "p4 ve p3  kopyaları oluşturuldu.");
            p1.IdInfo.IdNumber = 25;
            Console.WriteLine("p3 : " +p3.ToString() );
            Console.WriteLine("p4 : " + p4.ToString());
           



            Console.Read();
        }
    }
}
