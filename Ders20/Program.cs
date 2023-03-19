using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ders20
{
    internal class Program
    {
        static (int,string) Topla(int x, int y) => (x + y,$"Netice budur:{x+y}");
        //expression-bodied methods
        //=>-lambda operator
        //4 deq vaxt
        static (bool,int) LinearSearch(int[] arr,int target)
        {
            for (int i = 0; i < arr.Length; i++)
                if (arr[i].Equals(target)) return (true, i + 1);
            return (false,-1);
        }
        static (bool,int) BinarySearchWithIterativeWay(int[] arr,int target)
        {
            int start = 0;
            int end = arr.Length-1;
            while (end >= start)
            {
                int middle=(end+start)/2;
                if (target == arr[middle])
                {
                    return (true, middle+1);
                }
                else if(target<= arr[middle])
                {
                    end = middle - 1;
                }
                else
                {
                   start=middle + 1;
                }
            }
            return (false, -1);
        }
        static (bool, int) BinarySearchWithRecursiveWay(int[] arr, int target,int start,int end)
        {
            //int start = 0;
            //int end = arr.Length - 1;
            if(end >= start)
            {
                int middle = (end + start) / 2;
                if (target == arr[middle])
                {
                    return (true, middle + 1);
                }
                else if (target <= arr[middle])
                {
                    end = middle - 1;
                    return BinarySearchWithRecursiveWay(arr, target,start,end);
                }
                else
                {
                    start = middle + 1;
                    return BinarySearchWithRecursiveWay(arr, target, start, end);
                }
            }
            return (false, -1);
        }
        static void Value( ref int val)
        {
            val = 5;
            Console.Write(val);
        }
        static void Reference(ref string val)
        {
            val = "Murad";
            Console.WriteLine(val);
        }
        static void Main(string[] args)
        {
            //Tuple recursion binary search ref out
            //tuple bir nece geri donus tipi
            //var result = Topla(3, 4);
            //Console.WriteLine(result.Item1);
            //Console.WriteLine(result.Item2);
            //var some=(1,2,3);
            //Console.WriteLine(some.Item3);
            //Binary search-axtaris alqoritmi
            //linear search kimidir,amma daha suretlidir
            //linear bigo-o(N)
            //binary big-o(logn)
            //binary hedef arr yerini tapa bilirik
            //rekursiya-metodun ozunu tekrar cagirmasi
            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8,9 };
            //int target = 3;
            //var res=BinarySearchWithIterativeWay(arr, target);
            //Console.WriteLine(res.Item2);

            //int val = 12 ;
            //Console.WriteLine("Ededin metoddan evvelki deyeri:"+val);
            //Console.Write("Eedin metoddan sonra deyeri:");
            //Value(ref val);
            //Console.WriteLine("\nEdedin deyeri:"+val);
            //string some = "MMA";
            //string some=new some
            //Console.WriteLine(some);
            //Reference(ref some);
            //Console.WriteLine(some);
            //reference type
            object a = 5;
            a = 17;
            Console.WriteLine(a);//17
            object b = a;
            Console.WriteLine(b);//17
            string c = "some";
            c = "Murad";
            Console.WriteLine(c);//some
            string ad = c;
            Console.WriteLine(ad);//some

            Console.ReadLine();
        }
    }
}
