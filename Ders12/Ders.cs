using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders12
{
    public class Ders
    {
        //ctor
        public string z;
        public string x ;
        public string y ;
        //field default access modifier private
        //class default access modifier internal
        //constructor
        //method overloading
        //constructor overloading
        public Ders(string z)
        {
            this.z = z;
        }
        public Ders(string a, string b):this(a)
        {
            x = b;
        }
        
        public Ders(string a, string b, string c) : this(a, b)
        {
            //Console.WriteLine("salam");
            //z = "some";

            y = c;
        }
        //field

        public void Metod()
        {
            Console.WriteLine("Hello World");
        }
        public static void Metod1()
        {
            Console.WriteLine("Some");
        }
    }
}
