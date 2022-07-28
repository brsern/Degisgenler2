using System;

namespace Dikdortgen
{
    class Program
    {
        static void Main(string[] args)
        {

            int kisak, uzunk, alan, cevre;

            Console.Write("Kisa kenari giriniz : ");
            kisak = Convert.ToInt32(Console.ReadLine());

            Console.Write("Uzun kenari giriniz : ");
            uzunk = Convert.ToInt32(Console.ReadLine());

            alan = kisak * uzunk;
            cevre = 2 * (kisak + uzunk);


            Console.WriteLine("-----------");
            Console.WriteLine("Dikdortgen alani: {0} cevresi= {1}" ,alan, cevre); ;
            Console.ReadKey();
        }
    }
}
