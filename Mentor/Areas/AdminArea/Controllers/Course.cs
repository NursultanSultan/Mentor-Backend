using Mentor.DAL;
using Mentor.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Mentor.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    public class Course : Controller
    {
        private AppDbContext _context { get; }
        public Course(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var dbCourses = _context.Courses.Where(c => c.IsDeleted == false).ToList();

            List<CourseReadVM> courseVMs = new List<CourseReadVM>();

            foreach (var course in dbCourses)
            {
                CourseReadVM readVM = new CourseReadVM
                {
                    Id = course.Id,
                    CourseName = course.CourseName,
                    CourseDetail = course.CourseDetail,
                    CourseContent = course.CourseContent,
                    CourseImageUrl = course.CourseImage,
                    Price = course.Price,
                    TrainerName = course.TrainerName,
                    TrainerPhotoUrl = course.TrainerPhoto
                };

                courseVMs.Add(readVM);
            }

            return View(courseVMs);
        }
    }
}
