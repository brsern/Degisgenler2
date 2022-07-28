using System;

namespace Operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Matematiksel operatorler: + - * / %

            //int i = 5 % 2;

            //Console.Write("Deger :" + i);

            // iki operand farkli turdense sonuc daha ust kapasiteli turden olacak

            //float j = 5 / 2f;

            //Console.Write("Deger :" + j);

            //coklu islem

            //float k = 2f / 5 / 6 / 3 / 8;
            //  Console.Write("Deger :" + k);

            //bir artirma ve bir eksiltme operatoru
            //prefix onde kullanim
            //int a1 = 5;
            //int a2 = ++a1;

            //Console.WriteLine(a1 + " " + a2);
            ////suffix sonda kullanim
            //int a3= 5;
            //int a4= a3++;

            //Console.WriteLine(a3 + " " + a4);
            //int b1 = 5;
            //int b2 = --b1;

            //Console.WriteLine(b1 + " " + b2);
            ////suffix sonda kullanim
            //int b3 = 5;
            //int b4 = b3--;

            //Console.WriteLine(b3 + " " + b4);

            ////daha fazla ++ ve --
            //int a5 = 5;
            //int i5 = a5++;
            //int b5 = i5--;
            //int c5 = 10;
            //int d5 = --c5;
            //Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}\n", a5, i5, b5, c5, d5);

            //Karsilastirma operatorleri
            //bool a = 4 < 6;
            //bool b = 6 > 5;
            //bool c = 7 <= 7;
            //bool d = 9 >= 12;
            //bool e = 10 == 12;
            //bool f = 1 != 8;
            //Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n", a, b, c, d, e,f);

            //as operatoru
            //object i = "50";
            //string s = i as string;
            //Console.WriteLine(s);

            //int d = 60;
            //object o = d as object;
            //Console.WriteLine(o);

            //is operatoru

            int i = 50;

            bool b1 = i is int;
            bool b2 = i is double;
            bool b3 = 25 is byte;
            bool b4 = 'c' is string;
            bool b5 = 12f + 7 is int;


            Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}\n", b1, b2, b3, b4, b5);
           

            Console.ReadKey();
        }
    }
}
