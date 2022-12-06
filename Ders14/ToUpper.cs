using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders14
{
    public static class ToUpper
    {
        public static string Murad(this string x)
        {
            string gen = string.Empty;
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] >= 'a' && x[i] <= 'z')
                {
                    gen += (char)(x[i] - 32);
                }
                else
                {
                    gen += x[i];
                }
            }

            return gen;
        }

        public static int Uzunluq(this string x)
        {
            return x.Length;
        }
    }
}
