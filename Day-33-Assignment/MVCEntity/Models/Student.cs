using System.ComponentModel.DataAnnotations;

namespace StudentCourseManagement.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public List<Enrollment> Enrollments { get; set; }
    }
}