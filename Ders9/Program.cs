using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders9
{
    internal class Program
    {
        static void MyMethod()
        {
            Console.WriteLine("Salam Dunya");
        }
        static int Mymetod()
        {
            Console.WriteLine("Bura 7 verir");
            return 7;
            //return sondur
        }
        static int NumberGenerator()
        {
            Random random = new Random();
            return random.Next(0, 100);
        }
        static bool Checker()
        {
            int a = int.Parse(Console.ReadLine());
            if (a >= 0)
            {
                return true;
            }
            return false;
        }
        static int Toplama(int a,int b)
        {
            return a + b;
        }
        static int Converter(char a)
        {
            
            return a;
        }
        static int Some(int x=1,int y=2,int z=3)
        {
            return x * y * z;
        }
        static int[] FillArray(int[] arr,int n)
        {
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            return arr;
        }
        static void ShowArray(int[] arr, int n)
        {
            foreach (var item in FillArray(arr, n))
            {
                Console.Write(item + " ");
            }
        }
        static void ShowArr(params int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
        }
        static void Main(string[] args)
        {
            //geri donus tipi-void
            //return-default
            //return-break mentiqi
            //SOLID-Single Responsibility
            //MyMethod();
            //int a=Mymetod();
            //Console.WriteLine(a);
            //Console.WriteLine(NumberGenerator());
            //Console.WriteLine(Checker());
            //Console.WriteLine(Toplama(6,7));
            //parametr
            //argument
            //int x=Converter('6');
            //Console.WriteLine(x);
            //Console.WriteLine(Some());
            //Default/Optional Parameters
            //Console.WriteLine(Some(z:5,x:6));
            //Named Arguments
            //Method Signature
            //int n = 5;
            //int[] arr = new int[n];
            //ShowArray(arr, n);
            ShowArr(1, 2, 3, 4, 5);
            Console.ReadLine();
            //&& ||
        }
    }
}
