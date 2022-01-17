using Mentor.DAL;
using Mentor.Models;
using Mentor.Utilities.File;
using Mentor.ViewModel;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Mentor.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    public class CourseController : Controller
    {
        private AppDbContext _context { get; }
        private IWebHostEnvironment _env { get; }

        public CourseController(AppDbContext context , IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
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

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CourseCrudVM crudVM)
        {
            if (!ModelState.IsValid) return View();

            /*File upload start*/

            /*For course photo ---------------*/
            if (!crudVM.CoursePhoto.CheckFileType("image/"))
            {
                ModelState.AddModelError("CoursePhoto", "File must be image type");
                return View(crudVM);
            }

            if (!crudVM.CoursePhoto.CheckFileSize(300))
            {
                ModelState.AddModelError("CoursePhoto", "File must be less than 300kb");
                return View(crudVM);
            }

            string root = Path.Combine(_env.WebRootPath, "assets", "image");
            string CourseFileName = await crudVM.CoursePhoto.SaveFileAsync(root);
            /*For course photo ---------------*/

            /*For trainer photo ---------------*/

            if (!crudVM.TrainerPhoto.CheckFileType("image/"))
            {
                ModelState.AddModelError("TrainerPhoto", "File must be image type");
                return View(crudVM);
            }

            if (!crudVM.TrainerPhoto.CheckFileSize(300))
            {
                ModelState.AddModelError("TrainerPhoto", "File must be less than 300kb");
                return View(crudVM);
            }

            string TrainerFileName = await crudVM.TrainerPhoto.SaveFileAsync(root);

            /*For trainer photo ---------------*/

            /*File Upload end*/

            Course course = new Course
            {
                CourseName = crudVM.CourseName,
                CourseDetail = crudVM.CourseDetail,
                CourseContent = crudVM.CourseContent,
                CourseImage = CourseFileName,
                Price = crudVM.Price,
                TrainerName = crudVM.TrainerName,
                TrainerPhoto = TrainerFileName
            };

            await _context.Courses.AddAsync(course);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> Delete(int Id)
        {
            var dbCourse = _context.Courses.Find(Id);
            if (dbCourse == null) return NotFound();

            dbCourse.IsDeleted = true;

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
