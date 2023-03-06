using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders19
{
    public class Hello
    {
        
        enum WeekDays
        {
            Monday=1,
            Tuesday,
            Wednesday,
        }
        static int Num()
        {
            try
            {

                int[] values = new int[5] { 1, 2, 3, 4, 5 };
                //Console.WriteLine(values[6]);
                return 6;
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Her sey ugurludur");
            }
            
            return default(int);
        }
        static Kenan Print()
        {
            bool value = false;
            int x = 1;
            return new Kenan()
            {
                value = value,
                x = x,
            };
        }

        static void Main(string[] args)
        {
            #region Ders19
            //esas maindi
            //enum ve exception
            //enum-isareleme
            //int reqem = int.Parse(Console.ReadLine());
            //var days = WeekDays.Monday;
            //switch(days)
            //{
            //    case WeekDays.Monday:
            //        Console.WriteLine("Monday");
            //        break;
            //    case WeekDays.Tuesday:
            //        Console.WriteLine("Tuesday");
            //        break;
            //}
            //Console.WriteLine(WeekDays.Monday);
            //Exception
            //dividebyzero,nullreference,outofrange,stackoverflow
            //exception handling
            //try catch finally
            //Tuple Recursion Binary Search
            //try
            //{
            //    Console.WriteLine("Reqem daxil et:");
            //    int num=12;
            //    Console.WriteLine("Reqem daxil et:");
            //    int num1 = 0;
            //    Console.WriteLine(num/num1);
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Sistemde xeta bas verdi:" + ex.Message);
            //    Console.WriteLine(ex.ToString());
            //}
            //Exception-umumi sistemde gorduyu ilk xeta
            //read only property public string Name { get; }
            //write only property public string Name { set; }
            //try line by line
            //tools-options-text editor-all languages-line numbers
            //var val = Num();
            //Console.WriteLine(val);
            //metodda tryda return varsa finally islet
            //throw
            //if (5 > 3)
            //{
            //    throw new Exception("Bunun olmasini istemirem");
            //    throw new NotImplementedException();
            //    //interfeys memberi implement olunmayanda
            //}
            #endregion
            //tuple
            ar a = Print();
            Console.WriteLine($"deyer:{a.value},reqem:{a.x}");
            Console.ReadLine();
        }
    }
}
