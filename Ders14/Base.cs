using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders14
{
    public class Base//:Learn
    {
        public Base(int id,string name)
        {
            Id=id;
            Name=name;
            Console.WriteLine("Hello Base");
        }
        public int Id { get; set; }
        public string Name { get; set; }

        protected int Num = 5;
        //private public protected
        public void Print()
        {
            Console.WriteLine(Id+""+Name);
        }
        public virtual void Check(int num)
        {
            Console.WriteLine(123);
        }
        public virtual void Check1(int num)
        {
            
        }
    }
}
