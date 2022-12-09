using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._12._22
{
    internal class Class1
    {
        //default AM private
        //Class default internal
        //Oxunaqli || Genislendirile bilen || daha Rahat
        //class bir containerdir || ozellikleri tutur || onun vasitesile data idare olunur
        //class memberleri:
        // * Fiield || * Property || * Method
        //obyekt==instance || Obyekt static olmayan class memberlere erisim ucun
        //static - class a mexsusdur || obyekt yaradilaraq cagirilmir
        //Seperation of Concerns
        // static class - butun memberler static olur 
        //static classin obyekti yaradilmir
        //constructor class yaranan zaman ise dusen bir seydir
        //Prop + Tab Tab || CTor + Tab Tab || shortcut
        //This keyword class in icinde olan deyisken
        //constructor overloading
        //reference 1/0 nedir
        //This keyword constructorlarla islenmesi       
        // CTOR ardicilliq yoxdur
        // hansi parametrli ctor cagirilirsa ilk olaraq o isleyir
        /* OOP nin prinsipleri
         * + Encapsulation
         * - Polimorphizm
         * - Inheritance
         * - Abstraction                
         */
        //Encapsulation bir texnikadir 
        // 2 halda istiade olunur
        // 1 - Datanin gorunumunu mehdudlasdirmaq (Private deyiskeni diger classlarda almaq)

        // Getter setter ve prop usulu
        // Encapsulation 2 Usul - Butov bir datani tek halda almaq 
        //Valuable lifecycle
        //Debug in yaninda Undo (Ctrl+Z)|| Re Do
        


        public int Id { get; set; }
        public string Name { get; set; }
        public Class1(string name)
        {
            Name= name;
        }
        public Class1(int Id,string name):this(name)
        {
          this.Id= Id;
        }
        //public Class1(string name,int Id)
        //{
        //    Name = name;
        //    this.Id = Id;
        //}
        public Class1(int Id)
        {
            this.Id = Id;
        }
        public Class1()
        {
            Console.WriteLine("Salam");
        }
        public int b { get; set; } = 9;
        public static string c = "kenan";

        public void Method(int a, int b)
        {
            Console.WriteLine(a+b);

        }
        private int num = 12;

        //get - gostermek
        //set - alir

        public int Getter()
        {
           return num;
        }
        public void Setter(int a)
        {
            num = a;
        }
        public int Num
        { 
            get
            {
                return num;
            }
            set
            {
                num = value;
            }
        }
        //Code refactoring 
        //public void Student(string Name,int Id,int age)
        //{
        //    Console.WriteLine(Name + Id + age);
        //    Console.WriteLine(Name + (Id + age));
        //}
        public void Student(Value val)
        {
            Console.WriteLine(val.Name + val.Id + val.Age);

        }

    }
}
