using API.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Persistence.Context
{
    public static class Seed
    {
        public static void AddData(ModelBuilder builder)
        {
            var students = CreateStudents();
            var courses = CreateCourses();

            builder.Entity<Student>().HasData(students);
            builder.Entity<Course>().HasData(courses);
            builder.Entity<StudentCourse>().HasData(CreateStudentCourses(students,courses));

        }

        private static List<Student> CreateStudents()
        {
            List<Student> students = new List<Student>()
            {
                new Student{ Name = "", Surname = "", Number = ""},
                new Student{ Name = "", Surname = "", Number = ""},
                new Student{ Name = "", Surname = "", Number = ""},
                new Student{ Name = "", Surname = "", Number = ""},

            };

            return students;
        }

        private static List<Course> CreateCourses()
        {
            List<Course> courses = new List<Course>()
            {
                new Course{ Name = "", Code = ""},
                new Course{ Name = "", Code = ""},
                new Course{ Name = "", Code = ""},
                new Course{ Name = "", Code = ""},
            };

            return courses;
        }

        private static List<StudentCourse> CreateStudentCourses(List<Student> students, List<Course> courses)
        {
            List<StudentCourse> studentCourses = new List<StudentCourse>()
            {
                new StudentCourse{StudentId = students.ElementAt(0).Id, CourseId = courses.ElementAt(0).Id, Value = 50},
                new StudentCourse{StudentId = students.ElementAt(0).Id, CourseId = courses.ElementAt(0).Id, Value = 50},
                new StudentCourse{StudentId = students.ElementAt(0).Id, CourseId = courses.ElementAt(0).Id, Value = 50},
                new StudentCourse{StudentId = students.ElementAt(0).Id, CourseId = courses.ElementAt(0).Id, Value = 50},

                new StudentCourse{StudentId = students.ElementAt(1).Id, CourseId = courses.ElementAt(1).Id, Value = 50},
                new StudentCourse{StudentId = students.ElementAt(1).Id, CourseId = courses.ElementAt(1).Id, Value = 50},
                new StudentCourse{StudentId = students.ElementAt(1).Id, CourseId = courses.ElementAt(1).Id, Value = 50},
                new StudentCourse{StudentId = students.ElementAt(1).Id, CourseId = courses.ElementAt(1).Id, Value = 50},

                new StudentCourse{StudentId = students.ElementAt(2).Id, CourseId = courses.ElementAt(2).Id, Value = 50},
                new StudentCourse{StudentId = students.ElementAt(2).Id, CourseId = courses.ElementAt(2).Id, Value = 50},
                new StudentCourse{StudentId = students.ElementAt(2).Id, CourseId = courses.ElementAt(2).Id, Value = 50},
                new StudentCourse{StudentId = students.ElementAt(2).Id, CourseId = courses.ElementAt(2).Id, Value = 50},
            };
            return studentCourses;
        }
    }
}
