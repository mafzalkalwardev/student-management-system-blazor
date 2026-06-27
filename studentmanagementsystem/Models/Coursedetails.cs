namespace studentmanagementsystem.Models
{
    public class Courses
    {
        public int CourseID { get; set; }
        public string CourseTitle { get; set; }
        public string Instructor { get; set; }
        public string Department { get; set; }
        public string Duration { get; set; }
        public decimal Fee { get; set; }
        public string Status { get; set; }
    }
}
