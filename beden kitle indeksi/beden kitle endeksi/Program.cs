using System;

namespace beden_kitle_endeksi
{
    class Program
    {
        static void Main(string[] args)

        {
        

            Console.WriteLine("Kilonuzu Giriniz:" );
            int kilo= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Boyunuzu Giriniz: ");
            double  boy = Convert.ToDouble(Console.ReadLine());
         

            double bke = kilo / (boy * boy);

            if (bke < 18)
            {
                Console.WriteLine("ZAYIFSINIZ");
                Console.ReadLine();

            }
            else if (bke > 18 && bke < 25)
            {
                Console.WriteLine("NORMALSİNİZ");
                Console.ReadLine();
            }
            else if (bke > 25)
            { 
                Console.WriteLine("OBEZSİNİZ");
                Console.ReadLine();
            }
        }
    }
}
