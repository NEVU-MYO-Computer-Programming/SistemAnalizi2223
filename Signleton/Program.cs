using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signleton
{
    /*
     Tekillik dokusu (Singleton pattern): Bir sınıftan progam çalışırken sadece bir örnek oluşturulması isteniyorsa bu doku kullanılabilir. 
    Örnek : Bir uygulamanın tekrar tekrar açılmasını engellemek için.
     
     */

    internal class Program
    {
        static void Main(string[] args)
        {
            Kobay k1 = Kobay.OrnekOlustur;
            Kobay k2 = Kobay.OrnekOlustur;

            k1.DegerArttir(3);
            k1.DegerYazdir();
            k2.DegerArttir(5);

            k1.DegerYazdir();//Satır 24 de k2 değişkeni üzerinden değer arttırdık ama k1 üzerinden yazdırdık.

            Console.Read();


        }
    }
}
