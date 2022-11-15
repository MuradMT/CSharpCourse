using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ders10
{
    internal class Program
    {
        static string SumDob(double a, double b)
        {
            string topla = $"{a + b:0.0000}";
            string vur = $"{a * b:0.0000}";
            return string.Concat(topla, " ", vur);
        }
        static void Method(int[] a)
        {
            int b = a.Min();//O(1)
            int c = a.Max();//O(1)
            for (int i = 0; i < a.Length; i++)//O(n)
            {
                if (a[i] == b)
                {
                    Console.Write(c + " ");
                }
                else if (a[i] == c)
                {
                    Console.Write(b + " ");
                }
                else
                {
                    Console.Write(a[i] + " ");
                }
            }
        }
        //Metod{
        //for for
        //for
          //}
        static void SelectionSort(int[] arr)
        {
            //1 3 2 4 7 2
            int min, helper;
            for (int i = 0; i < arr.Length-1; i++)
            {
                min = i;
                for (int j = i+1; j< arr.Length; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j ;
                    }
                }
                helper = arr[min];
                arr[min] = arr[i];
                arr[i] = helper;
            }
        }
        static void BubbleSort(int[] arr)
        {
            //1 3 2 4 7 2
            int n=arr.Length;//O(1)
            for (int i = 0; i < n-1; i++)
            {
                for (int j = 0; j < n-i-1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int helper = arr[j];
                        arr[j] = arr[j + 1];    
                        arr[j + 1] = helper;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            //int n = int.Parse(Console.ReadLine());
            //string[] arr=new string[n];
            //for (int i = 0; i < n; i++)
            //{
            //    var num = Array.ConvertAll(Console.ReadLine().Split(), double.Parse);
            //    arr[i] = SumDob(num[0], num[1]);
            //}
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            //int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            //Alqoritmler Nezeriyyesi
            //Readable
            //Scalable
            //Big o -worth case
            //o(1)
            //O(n)
            //time complexity
            //space complexity
            //O(1)-O(N)-O(N^2)
            //zaman qazan ,yaddasda itir 
            //sorting alghoritms 
            //program-data structures+alghoritms
            //selection sort
            //bubble sort
            //searching alghoritms
            //linear  search 
            //1 3 2 4 7 2
            //int[] arr = { 1, 3, 2, 4, 7, 2 };
            //SelectionSort(arr);
            //BubbleSort(arr);
            //foreach (var item in arr)
            //{
            //    Console.Write(item+" ");
            //}
            //int a = 0;
            //int b = 0;
            //int d = 1;
            //double c = 0;
            //Console.WriteLine(d/c);
            //limit
            //NaN
            //sonsuzluq
            Console.ReadLine();
                
        }
    }
}
