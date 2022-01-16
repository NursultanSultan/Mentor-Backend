using Mentor.Models;
using System.Collections.Generic;

namespace Mentor.ViewModel
{
    public class HomeViewModel
    {
        public ICollection<Course> Courses { get; set; }
    }
}
