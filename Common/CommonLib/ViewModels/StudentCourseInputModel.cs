using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLib.ViewModels
{
    public class StudentCourseInputModel
    {
        public StudentInputModel StudentInputModel { get; set; }
        public CourseInputModel CourseInputModel { get; set; }
        public int Value { get; set; }

    }
}
