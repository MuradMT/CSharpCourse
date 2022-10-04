using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tapsiriqlar
            //1-Tercumeyi hal konsola cixar
            //2-Mini Kalkulyator proqrami yaz
            // comments
            Console.Write("bir");
            Console.WriteLine("Salam");
            Console.WriteLine("Dost lar");
            int num = 5;
            int kenan = 10;
            Console.WriteLine(num);
            Console.WriteLine(kenan);
            string name = "Murad";
            //cw+2 tab
            Console.WriteLine(name);
            double kesr = 5.7;
            Console.WriteLine();
            bool Turxan = false;
            Turxan = true;
            Console.WriteLine(Turxan);
            //escape symbols
            Console.WriteLine("Salam\t some");
            int Cavad = 7;
            int turxan = 3;
            int netice=Cavad%turxan;
            Console.WriteLine(netice);
            //+ - * / %
            Console.Write("Aleykum\n");
            //pascal Case
            //camel case
            int MyName = 6;
            byte deyer = 7;
            byte some = (byte)MyName;
            //xarici cevrilme
            int yeni = deyer;
            //daxili cevrilme
            int fuad = 88;
            byte deeyer = (byte)fuad;
            Console.WriteLine(deeyer);
            //string val=fuad.ToString();
            string value = "88";
            //metn birlesdirilmesi + isaresi ile 
            Console.WriteLine(value+fuad);
            double s1 = 9;
            double s2 = 5;
            int t1 = 9;
            int t2 = 5;
            Console.WriteLine(s1 / s2);
            Console.WriteLine(t1 / t2);

            //int nums = 10 / 0;
            //int num1 = 10;int num2 = 0;
            //Console.WriteLine(num1/num2);
            //compile time
            //run time
            int a = 5;
            //+= *= /= -= %=
            a += 1;
            a = a + 1;
            //post inkrement ,pre inkrement 
            int c = 9;
            //ctrl k ctrl c
            //Console.WriteLine(c++);
            int d = c++;
            int e = ++c;
            Console.WriteLine(d);
            Console.WriteLine(c);
            Console.WriteLine(e);
            Console.ReadLine();
           


        }
    }
}
