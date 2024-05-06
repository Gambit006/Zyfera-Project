using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Domain.Entities
{
    public class Course
    {
        public string Name { get; set; }
        public string Code { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
