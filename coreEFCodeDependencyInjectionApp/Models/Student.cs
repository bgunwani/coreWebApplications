﻿namespace coreEFCodeDependencyInjectionApp.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string? StudentName { get; set; }
        public List<StudentCourse>? StudentCourses { get; set; }
    }
}
