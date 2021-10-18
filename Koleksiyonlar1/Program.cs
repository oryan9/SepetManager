using System;
using System.Collections.Generic;

namespace Koleksiyonlar1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "ÖMER", "HALİL" };

            //Console.WriteLine(isimler[0]);

            //isimler = new string[5];
            //isimler[4] = "il";

            List<string> isimler2 = new List<string> { "Engin", " Ömer", "Faruk" };

            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[3]);



            




        }
    }
}
