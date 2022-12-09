
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._12._22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int @int = 5;
            //Console.WriteLine(@int);
            Class1 b = new Class1();
            //b.Setter(92);
            //int a =b.Getter();
            //b.Num = -56;
            //Console.WriteLine(b.Num);
            //Console.WriteLine(a);
            Value a = new Value()
            {
                Id = 1,
                Name = "Kenan",
                Age = 12
            };
            //b.Student(a);
            b.Student(new Value()
            {
                Id = 1,
                Name = "Kenan",
                Age = 12
            });
            Console.ReadLine();
            
            
            
        }
    }
}
