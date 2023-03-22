using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Ders21
{
    internal class Program
    {
        public delegate int MyDelegate(int x,int y); //funksiya containeri   
        static void Main(string[] args)
        {
            #region Codes
            //C# code nece kompilyasiya olunur
            //(c#-CIL)compile-(JIT-Native OS)runtime
            //c# delegates events-hadise
            //click event cagrilir mouseover event
            //delegate-metodun referans tutucusudur,metodun signature
            //Ozel delegate-Action Func Predicate
            //MyDelegate my;
            //my=new MyDelegate(Topla);
            //my += Cix;
            //my += Vur;
            //my += Bol;
            //var some=my.Invoke(4,5);
            //var some1 = my(3, 4);
            //Console.WriteLine(some);
            //Action<int, int> some = Yaz;//geriye void donderir
            //some(4, 5);
            //Action some1;//maksimum parametr sayi 16
            //Func<int,int,bool> some2=Topla;//son geri donus
            //Func<int> some3;
            //Predicate<int> some4;//geriye bool
            //delegate void DelName(int,int)
            //proyektde bu 3 ozel delegate novu islenir
            //anonymous methods
            //Action<int> some5= delegate (int x){
            //    Console.WriteLine(x);
            //};
            //Func<int,double> some6=(x)=>Math.Pow(x,2);//lambda operator
            //var res=some6(2);
            //Console.WriteLine(res);
            //anoymous types
            var res = new {  Id = "1", Name = "Some"};//compile-time
            Console.WriteLine(res.Id);
            //Design patterns
            //1.creational
            //2.behavioral
            //3.structural
            //syntax-problem solver
            //singleton
            //factory
            //var s = 1;
            //dynamic ad = 1;
            //ad = true;
            //object a = 1;
            //a = true;
            //delegateler bize metod icine metod yollamagimiza komek edir
            //string b = "1";
            //int y = 9;
            //dynamic k = b + y;
            //Console.WriteLine(k);
            //int a = 5;
            //int b = 16;
            //short circuit
            //if (a++ > b & b++ < 90)//False andde 1 teref false olsa netice false olur
            //    //yanliz 1 & her 2 terefi yoxlayir && ve & ferqi
            //{

            //}
            //if (a++ < b | b++ < 90)//True orda 1 teref true olsa netice true olur
            //                       //yanliz 1 | her 2 terefi yoxlayir || ve | ferqi
            //{

            //}
            //Console.WriteLine(b);
            //scope-local ve global
            //int a = 5;
            //{
            //    int b = 5;
            //    Console.WriteLine(a);
            //}
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //variable life cycle
            //try parse
            //string some = "123";
            //int val;
            //bool result = int.TryParse(some, out val);
            //if (result) Console.WriteLine(val);
            //bool result=MyTryParse(some, out val);
            //if (result) Console.WriteLine(val);
            //Console.ReadLine();
            #endregion
        }
        static bool MyTryParse(string t,out int x)
        {
            bool s = true;
            x=default(int);
            try
            {
                int val = int.Parse(t);
                x = val;
            }
            catch(Exception ex)
            {
                s = false;
            }
            return s;

        }
        static void Print(Func<int,int,int> some)
        {
            some.Invoke(4, 5);

        }
        static void Yaz(int x,int y)
        {
            Console.WriteLine(x+y);
        }
        static bool Topla(int x, int y) {
            Console.WriteLine("Topla");
            return true;
        }
            
        static int Cix(int x, int y)
        {
            Console.WriteLine("Cix");
            return x - y;
        }
        static int Vur(int x, int y)
        {
            Console.WriteLine("Vur");
            return x * y;
        }
        static int Bol(int x, int y)
        {
            Console.WriteLine("Bol");
            return x / y;
        }

    }
}
