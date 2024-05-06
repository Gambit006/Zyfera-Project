using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Domain.Entities
{
    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Number { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}
