using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElaveNezeriyye_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string immutabledir,elementleri uzerinde deyisiklik etmek olmur
            //yeni string arr=murad sozunde murad stringin 0cisidir
            //arr[0]=k yazib kurad yaratmaq mumkun deyil
            //amma array mutabledir,elementlerini deyismek olur
            //yeni int[] arr={1,2,3} kimi array varsa
            //onun 0ci elementi 1dir
            //arr[0]=5 yazib deyismek mumkundur
            //string-immutable array-mutable
            var arr = Console.ReadLine().ToCharArray();
            for (int i = 0; i < arr.Length - 1; i += 2)
            {
                char helper = arr[i];
                arr[i] = arr[i + 1];
                arr[i + 1] = helper;
            }
            Console.WriteLine(new string(arr));
            //finaldaki sonuncu meselenin optimal helli
            Console.ReadLine();
        }
    }
}
