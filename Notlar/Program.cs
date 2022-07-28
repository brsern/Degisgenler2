using System;
//ogrenci gecis ortalamasi
namespace Notlar
{
    class Program
    {
        static void Main(string[] args)
        {
            int not1, not2, not3;
            double ortalama;
            Console.Write("1. Not : ");
            not1 = Convert.ToInt32(Console.ReadLine());

            if (not1>100 && not1<0)
            {
                Console.WriteLine("Yanlis deger");
            }

            Console.Write("2.Not: ");
            not2= Convert.ToInt32(Console.ReadLine());

            Console.Write("3. Not : ");
            not3 = Convert.ToInt32(Console.ReadLine());

            ortalama = (not1 + not2 + not3) / 3;

            if (ortalama>=50)
            { //dogruysa
                Console.WriteLine("Tebrikler.. gectiniz.. ortalamaniz: {0} ", ortalama.ToString()); 
            }
            else
            { //yanlissa

                Console.WriteLine("Malasef.. birdaha deneyiniz.. ortalamaniz: {0} ", ortalama.ToString()); 
            }

            
            Console.ReadKey();
        }
    }
}
