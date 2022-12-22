using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders17
{
    public class Student : ISchoolMember
    {
        public int Id { get ; set ; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string University { get; set; }
        public string City { get; set; }
        public string Field { get; set; }
    }
}
