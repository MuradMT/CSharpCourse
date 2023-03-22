using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders22
{
    public class Test
    {
        public Test()
        {
            Console.WriteLine("Hello Test");
        }
        
        public int Age { get; set; }
        [Required]
        [MaxLength(4)]
        public static int year { get; set; }
        //sql
        public void Hello()
        {
            Console.WriteLine("Test");
        }
        public void Hi()
        {
            Console.WriteLine("Hi");
        }
        static void Salam()
        {
            Console.WriteLine("Salam");
        }
    }
}
