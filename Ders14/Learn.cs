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
        //static class obyektini yaratmaq olmur
        //butun class elementlerinin static olmasini istyirikse static class isledirik
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
