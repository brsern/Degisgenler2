using System;

namespace Toplama
{
    class Program
    {
        static void Main(string[] args)
        {

            int sayi1, sayi2, toplam;
            Console.Write("1.sayiniz : ");
            sayi1 = Convert.ToInt32 (Console.ReadLine());

            Console.Write("2.sayiniz : ");
            sayi2 = Convert.ToInt32(Console.ReadLine());

            toplam = sayi1 + sayi2;




            Console.WriteLine("{0} ve {1} Sayilarinin toplami= {2}" ,sayi1, sayi2, toplam);
            Console.ReadKey();
        }
    }
}
