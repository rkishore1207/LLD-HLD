namespace GroupJoin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var studentsWithCourses = new Student().GetAllStudents()
                .GroupJoin(new Course().GetAllCourses(), s => s.StudentId, c => c.StudentId, (student, courses) => new
                {
                    StudentWithCourse = student,
                    Courses = courses.OrderBy(course => course.CourseName).ToList()
                }).OrderBy(student => student.StudentWithCourse.Name).ToList();
            foreach (var student in studentsWithCourses)
            {
                Console.WriteLine(student.StudentWithCourse.Name);
                foreach(var course in student.Courses)
                {
                    Console.WriteLine(" " + course.CourseName);
                }
                Console.WriteLine();
            }
        }
    }
}
