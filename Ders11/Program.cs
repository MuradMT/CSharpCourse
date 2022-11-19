using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders11
{
    internal class Program
    {
        #region gen
        static void Metod(int x)
        {
            Console.WriteLine(x);
        }
        static void Metod(string y)
        {
            Console.WriteLine(y);
        }
        static void Value(params int[] arr)
        {
          List<int> list = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]%2==0)
                {
                    list.Add(arr[i]);
                }
            }
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
        
        static bool Kenan(List<string> list)
        {
            bool value = false;
            string target = "Murad";
            foreach(var item in list)
            {
                if (item == target)
                {
                    value= true;
                }
            }
            return value;
        }
        static bool Cavad(List<string> list)
        {
            string target = "Murad";
            return list.Contains(target);
        }
        static List<int> Menfieded(List<int> list)
        {
            List<int> result=new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i]<0)
                {
                    result.Add(list[i]);
                }
            }
            return result;
        }
        static List<string> Result(params int[] arr)
        {
            List<string> result = new List<string>();
            for (int i = 0; i < arr.Length; i++)
            {
                result.Add($"{Math.Sqrt(Convert.ToDouble(arr[i]))} {Math.Pow(Convert.ToDouble(arr[i]), 2)}");
            }
            return result;
        }
        #endregion
        static bool Anagram(string x)
        {
            string res = string.Empty;
            for (int i = x.Length-1; i >=0; i--)
            {
                res += x[i];
            }
            return res == x;
        }
        static List<string> Check(List<string> liste)
        {
            List<string> strings = new List<string>();
            for (int i = 0; i < liste.Count; i++)
            {
                if (Anagram(liste[i]))
                {
                    strings.Add(liste[i]);
                }
            }
            return strings;
        }
        static void Main(string[] args)
        {
            #region some
            //string x = Console.ReadLine();
            //foreach (var item in x.Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries))
            //{
            //    Console.WriteLine(item);
            //}
            //Metod overloading
            //Metod(5);
            //Metod("Salam");
            //Non generic Collections -object array
            //Generic Collections- normal array 
            //using System.Collections;
            //ArrayList arrayList = new ArrayList();
            //string z= "some";
            //int t = 5;
            //double k = 9;
            //arrayList.Add(t);
            //arrayList.Add(z);
            //arrayList.Insert(0, k);
            //arrayList.Remove(arrayList[0]);
            //Console.WriteLine( arrayList.Contains(5));
            //object initializer syntax
            // var list = new ArrayList()
            //{
            //  t,z
            //};
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}
            //for
            //Console.WriteLine(arrayList[0]);
            //Console.WriteLine(arrayList.Count);
            //List<int> list = new List<int>();
            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //list.Add(4);
            //Value(1, 2, 3, 4, 5, 6);
            //List<string> list = new List<string>()
            //{
            //    "kenan","Murad","cvad"
            //};
            //Console.WriteLine(Cavad(list));

            //List<int> list = new List<int>()
            //{
            //    0,3,1,2,-4,-9,2,-7
            //};
            //foreach (var item in Menfieded(list))
            //{
            //    Console.WriteLine(item);
            //}
            //Random rand= new Random();
            //foreach (var item in Result(rand.Next(1,10), rand.Next(1, 10),
            //    rand.Next(1, 10), rand.Next(1, 10)))
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            List<string> list = new List<string>()
            {
                "ezize","Murad","kelek"
            };
            foreach (var item in Check(list))
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

            

        }
    }
}
