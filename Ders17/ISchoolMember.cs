using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders17
{
    public interface ISchoolMember
    {
        int Id { get; set; }
        string Name { get; set; }
        string SurName { get; set; }
        string University { get; set; }
        string City { get; set; }
        string Field { get; set; }
    }
}
