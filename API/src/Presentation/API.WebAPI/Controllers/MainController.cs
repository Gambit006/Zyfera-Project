using API.Domain.Entities;
using API.Persistence.Context;
using CommonLib.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace API.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MainController : ControllerBase
    {

        public AppDbContext AppDbContext;

        public MainController(AppDbContext appDbContext)
        {
            AppDbContext = appDbContext;
        }

        [HttpPost]
        public IActionResult Post(StudentCourseInputModel inputModel)
        {
            if (inputModel.Value > 100 || inputModel.Value < 0)
                return Ok(new Exception("Grade cannot be over 100 or under 0"));
            Student student = new Student
            {
                Id = Guid.NewGuid(),
                Name = inputModel.StudentInputModel.Name,
                Surname = inputModel.StudentInputModel.Surname,
                Number = inputModel.StudentInputModel.Number,
            };
            AppDbContext.Add(student);

            Course course = new Course
            {
                Id = Guid.NewGuid(),
                Name = inputModel.CourseInputModel.Name,
                Code = inputModel.CourseInputModel.Code,
            };
            AppDbContext.Add(course);


            StudentCourse studentCourse = new StudentCourse
            {
                Id = Guid.NewGuid(),
                Student = student,
                Course = course,
                Value = inputModel.Value,
            };
            AppDbContext.Add(studentCourse);
            AppDbContext.SaveChanges();

            return Ok(studentCourse);
        }



    }
}
