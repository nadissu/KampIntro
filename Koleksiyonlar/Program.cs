using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[]  isimler = new string[]{ "Nadide", "Sultan", "Perihan", "Oğuzhan" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);


            List<string> isimler2 = new List<string> { "Nadide", "Sultan", "Perihan", "Oğuzhan" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İbrahim");
            Console.WriteLine(isimler2[0]);
            



        }
    }
}
