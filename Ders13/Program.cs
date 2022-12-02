using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders13
{
    internal class Program
    {
        static bool Check(Data data)
        {
            if (data.Age > 10)
            {
                return true;
            }
            return false;
        }
        //encapsulation 2 istifadesi butov datani tek halda almaq veya cixarmaq
        static void Printer(ValueKeeper keep)
        {
            Console.WriteLine(keep.x + " " + keep.y+""+keep.t);
        }
        static void Main(string[] args)
        {
            #region Notes
            //OOP
            //4
            //encapsulation
            //1-datanin gorunumunu mehdusladiriq,proqramatik olaraq onu elde edirik
            //polimorfizm
            //abstraction
            //inheritance
            //Students students = new Students("murad",1,19,"mammadzada");
            //Console.WriteLine(students.Id);
            //Console.WriteLine(students.Getter());
            //Students students = new Students();
            //students.Setter(5);
            //Console.WriteLine(students.Getter());
            //Students students = new Students();
            //students.Num = 12;
            //Console.WriteLine(students.Num);
            // Git-emrler,versiya nearet sistemi 
            //Github-depo,git emrleri 
            //add to source control
            //repository-private ve public
            //readme-proyekt haqqinda melumat verir
            //commit
            //push-githuba yollamaq
            //pull-githubdan cekmek
            //sync-pull then push
            //stage 
            //undo changes
            //github mobile
            //github for collobration
            //class-reference type
            //List<Students> list = new List<Students>();
            //Students student = new Students("murad",1,19,"mammadzada");
            //Students students1 = new Students("kenan", 2, 17, "eminli");
            //list.Add(student);
            //list.Add(students1);
            //object initializer syntax
            //List<Students> list = new List<Students>()
            //{
            //    new Students("murad",1,19,"mammadzada"),
            //    new Students("kenan", 2, 17, "eminli")
            //}; 
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item.Age);
            //}
            //class public age field constructorla
            //program list list classi elave edir
            //age >10 ekrana sert odenilmir
            //sert odenilir
            //data
            #endregion
            List<Data> datas = new List<Data>();
            Data data = new Data(7);
            Data data2 = new Data(13);
            Data data3 = new Data(9);
            Data data4 = new Data(15);
            datas.Add(data);
            datas.Add(data2);
            datas.Add(data3);
            datas.Add(data4);
            List<Data> original = new List<Data>();
            for (int i = 0; i < datas.Count; i++)
            {
                if (Check(datas[i]))
                {
                    original.Add(datas[i]);
                }
                else
                {
                    Console.WriteLine("Data 10dan boyuk olmalidir");
                }
            }
            foreach (var item in original)
            {
                
                Console.WriteLine(item.Age);
            }
            //@ xususi c # terminlerini variable name kimi qoymaga komek edir
            int @int = 0;
            Console.WriteLine(@int);
            Console.ReadLine();
            
        }
    }
}
