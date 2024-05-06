using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Domain.Entities
{
    [Table("Courses", Schema = "dbo")]
    public class Course
    {
        [Key]
        public Guid Id { get; set; }

        [Column(TypeName = "nvarchar(500)")]
        public string Name { get; set; }


        [Column(TypeName = "nvarchar(5)")]
        public string Code { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
