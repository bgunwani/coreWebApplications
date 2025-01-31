using System.ComponentModel.DataAnnotations.Schema;

namespace coreEFCodeDependencyInjectionApp.Models
{
    public class StudentCourse
    {
        
        public Student? Student { get; set; }
        public Course? Course { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }

    }
}
