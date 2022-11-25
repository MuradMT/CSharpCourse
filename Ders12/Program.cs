using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders12
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //using bir proyekte diger proyekti elave edir
            //bir proyekti digerinde istifade etmek ucun referans verilmelidir
            //OOP
            //class 
            //string x = "salam";
            //string y = "hello";
            //Ders some=new Ders();
            //classin obyektini yaratmaq
            //access modifiers
            //public private
            //internal class 2 access modifiers
            //some.x = "assa";
            //some.Metod();
            //var t=some.x;
            //Ders.Metod1();
            //Console.WriteLine(some.x);
            Ders ders = new Ders("z","x");
            //eolimp leetcode hackerrank
            Console.WriteLine(ders.z);
            Console.ReadLine();
        }
    }
}
