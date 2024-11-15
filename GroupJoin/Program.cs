namespace GroupJoin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Group Join - Hierarchial Result Set
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

            // Inner Join - Flat Result Set
            var students = new Student().GetAllStudents()
                .Join(new Course().GetAllCourses(), student => student.StudentId, course => course.StudentId, (student, course) => new
                {
                    StudentwithCourse = student.Name,
                    CoursewithStudent = course.CourseName,
                });
            foreach (var student in students)
            {
                Console.WriteLine(student.StudentwithCourse + " - " + student.CoursewithStudent);
            }
        }
    }
}
