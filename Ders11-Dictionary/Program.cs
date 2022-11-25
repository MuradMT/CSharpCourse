using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders11_Dictionary
{
    internal class Program
    {
        static void mixed(Dictionary<int, string> dick1, Dictionary<int, string> dick2)
        {
            Dictionary<int, string> dick3 = new Dictionary<int, string>();
            for (int i = 0; i < dick1.Count; i++)
            {
                dick3.Add(i, dick1[i]);
                dick3.Add(i + dick2.Count, dick2[i]);
            }
            foreach (var item in dick3)
            {
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {
            Dictionary<int, string> dick1 = new Dictionary<int, string>();
            dick1.Add(0, "Rehim");
            dick1.Add(1, "kenan");
            dick1.Add(2, "Cebi");
            Dictionary<int, string> dick2 = new Dictionary<int, string>();
            dick2.Add(0, "Turxan");
            dick2.Add(1, "Besire");
            dick2.Add(2, "Cvad");
            mixed(dick1, dick2);
            Console.ReadLine();
        }
    }
}
