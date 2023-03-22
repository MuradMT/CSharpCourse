using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Ders22
{
    internal class Program
    {
        static  void Main(string[] args)
        {
            //reflection-runtime 
            //reflection kodlari proqramatik sekilde deyismeye
            //kodlari manual isletmeye komek edir
            //Assembly
            //var test = new Test();
            //namespace ve using
            var asm=Assembly.GetExecutingAssembly();
            //var type = asm.GetTypes();
            //foreach (var item in type)
            //{
            //    Console.WriteLine(item);
            //}
            var type = asm.GetType("Ders22.Test");//Type
            //class instansi yaratmaq
            var ins=Activator.CreateInstance(type);
            //var prop = type.GetProperties();
            //foreach (var item in prop)
            //{
            //    Console.WriteLine(item);
            //}
            //var prop = type.GetProperty("Age");
            //prop.SetValue(ins, 11);
            //Console.WriteLine(prop.GetValue(ins));
            //var metod = type.GetMethod("Hi");
            //metod.Invoke(ins, new object[] { });

            //foreach (var item in metod)
            //{
            //    Console.WriteLine(item);
            //}
            //var prop1= type.GetProperty("year", BindingFlags.NonPublic | BindingFlags.Static);
            //private static 
            //prop1.SetValue(null, 12);//instance yerine null
            //Console.WriteLine(prop1.GetValue(null));
            //Bindingflags:
            //1.Public
            //2.Non-Public
            //3.Instance
            //4.Static
            //volkan aktas-her yonuyle c# 9
            //attribute-classinin metodunun properytinin goreceyi isi mueyyenlesdiren,
            //onu mehdudluq veren bir c# ozelliyidir
            //Test.year = 13122;
            //Console.WriteLine(Test.year);
            //pointer yaddasa elde ede bilirik c c++
            //safe dildi,unsafe deyil
            //pointer deyiskenin yaddasda unvanini saxlayir
            //metoda unsafe elave 
            unsafe
            {
                //xeta olarsa uste gel unsafe kodun proyektde islemesine icaze ver
                //main uzerinede unsafe yazsan dogrudur
                int var = 20;//stack ad deyer unvan
                int* p = &var;
                Console.WriteLine("Data is: {0} ", var);
                Console.WriteLine("Address is: {0}", (int)p);
                
            }
            //unmanaged and managed code
            //sql database,file kod almaga
            //using ()
            //{
            //IDisposable interfeysi
            //}
            //1.namespace import etmek
            //2.unmanaged kodlari idare etmek
            //Garbage Collector
            //ref ve out
            //array  stack-ad  heap-deyer(orphan object)-GC
            //arr=yemi deyerler   heap-yeni
            //ad-yeni
            //readkey read
            //Console.Read();-int
            //Console.ReadLine();-string
            var keyInfo= Console.ReadKey();
            if (keyInfo.Key == ConsoleKey.Escape)
            {
                Console.WriteLine("this is escape button");
            }
            else if(keyInfo.Key==ConsoleKey.Spacebar)
            {
                Console.WriteLine("Sen bosluga basdin ozunu yigisdir");
            }
            Console.ReadKey();//-ConsoleKeyinfo
        }
    }
}
