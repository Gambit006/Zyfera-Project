using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Domain.Entities
{
    [Table("Students", Schema = "dbo")]
    public class Student
    {
        [Key]
        public Guid Id { get; set; }

        [Column(TypeName ="nvarchar(100)")]
        public string Name { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Surname { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Number { get; set; }

        public virtual ICollection<StudentCourse> StudentCourses { get; set; }
    }
}
