using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders13
{
    public class Students
    {
        
        public string FirstName;//pascal case
        private int Id;
        public int Age;
        public string lastName;//camel case
        public Students(string firstName, int id, int age, string lastName)
        {
            FirstName = firstName;
            Id = id;
            Age = age;
            this.lastName = lastName;
        }
        public int Getter()
        {
            return Id;
        }
        public void Setter(int id)
        {
            this.Id = id;
        }
        //property

        public string Some { get; set; }//public string Some;
        private int num;
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
    }
}
