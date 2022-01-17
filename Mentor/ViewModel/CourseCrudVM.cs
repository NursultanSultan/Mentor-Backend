using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Mentor.ViewModel
{
    public class CourseCrudVM
    {

        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string CourseName { get; set; }

        [Required, MaxLength(50)]
        public string CourseDetail { get; set; }

        [MaxLength(255)]
        public string CourseContent { get; set; }

        [Required]
        public decimal Price { get; set; }

        [NotMapped,Required]
        public IFormFile CoursePhoto { get; set; }

        [Required]
        public string TrainerName { get; set; }

        [NotMapped]
        public IFormFile TrainerPhoto { get; set; }
    }
}
