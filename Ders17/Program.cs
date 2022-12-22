using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Ders17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //custom list
            //string builder+
            //nullable types+
            //?? operator+
            //is as operators+
            //solid i ve d+
            //indexer
            //generics
            #region Notes
            //List<ISchoolMember> list ;
            //bool x = false;
            //switch (x)
            //{
            //    case true:
            //        list = new List<ISchoolMember>
            //        {
            //            new Student()
            //            {
            //                Id=1,
            //                Name="Telebe Murad",
            //                SurName="Mammadzada",
            //                City="Baku",
            //                Field="Computer Science",
            //                University="DIA"
            //            }
            //        };
            //        break;
            //        default:
            //        list = new List<ISchoolMember>
            //        {
            //            new Teacher()
            //            {
            //                Id=1,
            //                Name="Muellim Murad",
            //                SurName="Mammadzada",
            //                City="Baku",
            //                Field="Computer Science",
            //                University="DIA"
            //            }
            //        };
            //        break; 
            //}
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item.Name);
            //}
            //I-Interface segregation
            //S class,metodlara
            //i sin interface qarsiligidir
            //yeni her interfeysin 1 isi olmalidir
            //D-Dependency Inversion 
            //asililiqlari konkretlik uzerinden yox muceredlik uzerinden qur
            //bu prinsipe emel etmek ucun interfeyslerden istifade olunur
            //string x = "Murad";
            //x[0] = "s";
            //string immutable
            //StringBuilder sb = new StringBuilder("Murad");
            //sb.Append(x);
            //sb[0] = 's';
            //Console.WriteLine(sb);
            //Console.WriteLine(sb.Length);
            //int num = null;//value tiplere
            //string n = null;//referans tiplere
            //int? num = null;
            //string x = null;
            //string y = "Some";
            //Console.WriteLine(x??"Bu deyisken bosdur");
            //Console.WriteLine(y ?? "Bu deyisken bosdur");
            //as operatoru yanlis referans tiplerle isleyir
            //int y = 5;
            //bool k = y is int;
            //object val = "hj";//5
            //string x = val as string;
            //Console.WriteLine(k);
            //Console.WriteLine(x+"ser");
            #endregion
            Console.ReadLine();
        }
    }
}
