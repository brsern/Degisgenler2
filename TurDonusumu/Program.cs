using System;

namespace TurDonusumu
{
    class Program
    {
        static void Main(string[] args)
        {
            //bilincsiz-implicit tur donusumleri

            //byte a = 10;
            //short b = 5;
            //sbyte c = 30;
            //int d = a + b + c;

            ////------

            //string e = "deneme";
            //char f = '1';
            //object g = e + f + d;
            //long h = d;
            //float i = h;
            //double j = i;
            //double k = 25.8f;


            //Console.WriteLine(j+k);

            //Bilincli tur donusumu
            //Genelde derleyicinin izin vermedigi durumlarda zorlama yapilan donusumler

          //  int a1 = 5;
          //  byte b1 = (byte)a1;

          //  Console.WriteLine(a1 + " " + b1);

          //  int c1 = 100;
          //  byte i1 = (byte)c1;

          //  Console.WriteLine(c1 + " " + i1);

          //  int d1 = 600;
          //  byte j1 = (byte)d1;

          //  Console.WriteLine(d1 + " " + j1);

          //  //object turu
          //  //object turundeki bir degiskene herhangi baska herhangi bir turdeki degisken veya sabit (string disinda) + isaretiyle eklenemez

          //  object o= "5";
          //  int k1 = 5;
          //Console.WriteLine(o + " " + k1);

            //object a= "5";
            //int b= (int)a;
            //Console.WriteLine(b);

            //object a1 = 'k';
            //char b1 = (char)a1; //ayni tipte oldugu icin cevirebildi
            //Console.WriteLine(a1  + " " + b1);

            //string donusumleri
            //string s1 = 5.ToString();
            string s1;
            int s2 = 5;//s2 stringe ceviriyoruz
            //s1 = s2.ToString();
            s1 = Convert.ToString(s2);//usttekiyle ayni
            Console.WriteLine(s2 + "----> " + s1);


            Console.ReadKey();
        }
    }
}
