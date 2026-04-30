using System.ComponentModel.DataAnnotations;

namespace StudentCourseManagement.Models
{
    public class Course
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public int Credits { get; set; }

        public List<Enrollment> Enrollments { get; set; }
    }
}