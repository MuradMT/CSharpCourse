using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders14
{
    public class Derived : Base
    {
        //1 class yanliz 1ini inherit eder
        public Derived(int id, string name) : base(id, name)
        {
            Console.WriteLine("Hello Derived"+Num);
        }
        //Open Closed Principle
        public override void Check(int num)
        {
            if (num > 0)
            {
                Console.WriteLine(num);
            }
        }
        
        public override void Check1(int num)
        {
            if (num > 5)
            {
                Console.WriteLine(num);
            }
        }
    }
}
