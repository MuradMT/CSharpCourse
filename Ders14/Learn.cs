using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders14
{
    public sealed class Learn
    {
        //prop+2 tab
        //obyektini yaratmaq olur
        //butun class elementlerinin static olmasini istyirikse
        public static int Some  { get; set; }

        public static void Hello()
        {
            Console.WriteLine(1);
        }

        public static void Hello(int x)
        {
            Console.WriteLine(x);
        }
    }
}
