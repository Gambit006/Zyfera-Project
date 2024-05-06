using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Domain.Entities
{
    [Table("StudentCourses")]
    public class StudentCourse
    {
        [Key]
        public Guid Id { get; set; }

        public Guid StudentId { get; set; }

        public Guid CourseId { get; set; }

        [AllowNull]
        public int Value { get; set; }
        
        
        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}
