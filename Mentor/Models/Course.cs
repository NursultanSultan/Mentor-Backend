using System.ComponentModel.DataAnnotations;

namespace Mentor.Models
{
    public class Course
    {
        public int Id { get; set; }
        [Required ,MaxLength(50)]
        public string CourseName { get; set; }

        [Required , MaxLength(50)]
        public string CourseDetail { get; set; }

        [MaxLength(255)]
        public string CourseContent { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public string CourseImage { get; set; }

        [Required]
        public string TrainerName { get; set; }

        public string TrainerPhoto { get; set; }

    }
}
