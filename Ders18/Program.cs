using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Ders18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<int> list = new List<int>();
            //list.Add(1);
            //list.Add(2);
            //list.Remove(1);
            //Console.WriteLine(list.Count);
            //Console.WriteLine(list[0]);
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            //---
            //Add
            //0-1 
            MyList<int> myList = new MyList<int>();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(2);
            myList.Remove(2);
            WriteLine(myList.Count);
            foreach (var item in myList.Data)
            {
                Console.WriteLine(item);
            }

            WriteLine(myList.Contains(5));

            WriteLine(myList[1]);

            MyList<string> list = new MyList<string>();
            list.Add("kenan");
            list.Add("Murad");
            foreach (var item in list.Data)
            {
                Console.WriteLine(item);
            }
            ReadLine();
        }
    }
}
