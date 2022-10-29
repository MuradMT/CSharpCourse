using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = { 1, 2, 3, 4, 5 };
            //int max=arr[0];
            //for (int i = 1; i <arr.Length; i++)
            //{
            //    if (max < arr[i])
            //    {
            //        max = arr[i];
            //    }
            //}
            //Console.WriteLine(max);
            //string[] some = Console.ReadLine().Split('2');
            //for (int i = 0; i < some.Length; i++)
            //{
            //    Console.WriteLine(some[i]);
            //}
            //int[] arr1 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    Console.WriteLine(arr1[i]);
            //}
            //int[] arr = { 1, 2, 3, 4, 5 };
            //object[] arr2 = { 1, 2, 3, 4, 5,"h" };

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //
            //multi dimensional-matris
            int[,] some = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(some[i, j]);
                }
                Console.WriteLine();

            }
            //1 2 3
            //4 5 6 
            //some[i,j]
            //Jagged Array
            int[][] arr = new int[2][] { new int[] { 4, 5, 6 } , new int[] { 5, 6, 7 } };
            Console.WriteLine(arr[0][0]);
            Console.ReadLine();
        }
    }
}
