using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signleton
{
    public class Kobay
    {
        //public static int StaticDeger;
        private static Kobay ornek;
        private int deger = 0;
        public static Kobay OrnekOlustur
        {
            get
            {
                if (ornek == null)
                {
                    ornek = new Kobay();
                }
                return ornek;
            }
        }
        private Kobay()
        {
            Console.WriteLine("Kobay türünde bir nesne oluştu.");
        }
        public void DegerArttir(int miktar)
        {
            deger += miktar;
        }
        public void DegerYazdir() {
            Console.WriteLine($"Şuanda değer : {deger}");
        }


    }
}
