namespace GroupJoin
{
    public class Course
    {
        public int StudentId { get; set; }
        public string CourseName { get; set; }

        public List<Course> GetAllCourses()
        {
            return new List<Course>
            {
                new Course { StudentId = 1, CourseName = "Science" },
                new Course { StudentId = 1, CourseName = "Math" },
                new Course { StudentId = 2, CourseName = "History" }
            };
        }
    }
}
