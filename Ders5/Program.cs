using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ders5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string metodlari,@
            //int n=int.Parse(Console.ReadLine());
            //int sum = 0;
            //for (int i = 1; i <=n; i++)
            //{
            //    sum += i;
            //}
            //Console.WriteLine(sum);
            //while (true)
            //{
            //    int num = int.Parse(Console.ReadLine());
            //    if (num >= 0)
            //    {
            //        break;
            //    }
            //}
            //string some;
            //do
            //{
            //    some = Console.ReadLine();
            //    Console.WriteLine(some);
            //} while (some != "Admin");
            //string some = @"/sdjbvsdj\ds\\v\\";
            //double num = 5.45678;
            //string name = "Murad";
            //string b = "";
            //string c=string.Empty;
            //start:
            ////codes
            //goto start;
            //Console.WriteLine(num.ToString());
            //Console.WriteLine(name.Length);
            //Console.WriteLine(name.Contains("z"));
            //Console.WriteLine(name.IndexOf("z"));
            //Console.WriteLine(name.Substring(0, 1));
            //Console.WriteLine(name.StartsWith("M"));
            //Console.WriteLine(name.EndsWith("k"));
            //Console.WriteLine(name.Equals("murad"));
            //Console.WriteLine(name.Insert(0, "deyer"));
            //Console.WriteLine(name.Remove(2, 3));
            ////Remove ve substring bir birinin tersidir
            //Console.WriteLine(name.ToLower());
            //Console.WriteLine(name.ToUpper());
            //Console.WriteLine(name.TrimStart());
            //Console.WriteLine(name.TrimEnd());
            //Console.WriteLine(name.Trim());
            //Console.WriteLine(string.Concat(b+" ",name));
            //string format bax
            //Console.WriteLine(name.Replace(name[2],'s'));
            //string name = "Murad";
            //string newname = string.Empty;
            //for (int i = 0; i <name.Length; i++)
            //{
            //    if (name[i] >= 'A' && name[i] <= 'Z')
            //    {
            //        newname += (char)(name[i] + 32);
            //    }
            //    else
            //    {
            //        newname += name[i];
            //    }
            //}
            //Console.WriteLine(newname);
            //int num = int.Parse(Console.ReadLine());
            //bool value = true;
            //for (int i = 2; i <num; i++)
            //{
            //    if (num % 2 == 0)
            //    {
            //        value = false;
            //    }
            //}
            //Console.WriteLine(value==true?"Sade ededdir":"Sade eded deyil");
            int num= int.Parse(Console.ReadLine());
            int res = 1;
            for (int i = 1; i <=num; i++)
            {
                res *= i;
            }
            Console.WriteLine(num==0?"1":$"{res}");
            Console.ReadLine();
        }
    }
}
