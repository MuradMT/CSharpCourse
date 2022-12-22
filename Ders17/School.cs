using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders17
{
    public class School
    {
        List<Student> students;
        List<Teacher> teachers;
        public School(List<Student> students, List<Teacher> teachers)
        {
            this.students = students;
            this.teachers = teachers;
        }
        public List<Student> StudentDetails()
        {
            return students;
        }
        public List<Teacher> TeacherDetails()
        {
            return teachers;
        }
        public string Name { get; set; }
        public string City { get; set; }
        public virtual void SchoolDetails()
        {
            Console.WriteLine(Name+City);
        }
    }
}
