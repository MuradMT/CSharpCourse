using Ders12;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Solution explorer
            //proyekt elave et,sil
            Console.WriteLine("Hello World");
            //statik dinamik
            int value = 5;
            //Parse 
            //double . , olmasi arasdiracam
            int newvalue=int.Parse(Console.ReadLine());
            Console.WriteLine("1-ci eded:");
            Console.WriteLine(newvalue);
            double val=double.Parse(Console.ReadLine());
            Console.WriteLine(val);
            
            double num=5.7;
            //Convert ve Parse Ferqi
            //int numb = int.Parse(num);
            int numb1=Convert.ToInt32(num);
            Console.WriteLine();
            //tiplerin default deyerleri
            int sum=default(int);
            Console.WriteLine(sum);
            //if else if else
            //> < == != && || ! operatorlari
            
            Console.ReadLine();
        }
    }
}
