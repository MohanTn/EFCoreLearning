using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreLearning.Domain
{
    public class Student
    {
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Course> Courses { get; set; }
    }
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public List<Student> Students { get; set; }
    }
    public class studentCourse
    {
        public int StudentCourseID { get; set; }
        public Student student { get; set; }
        public Course course { get; set; }
    }
}
