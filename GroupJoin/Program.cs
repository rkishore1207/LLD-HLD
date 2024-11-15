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

            // Left Outer Join
            Console.WriteLine("\n" + "Left Outer Join");
            var studentsLeftJoin = new Student().GetAllStudents()
                .GroupJoin(new Course().GetAllCourses(), student => student.StudentId, course => course.StudentId, (student, courses) => new
                {
                    stu = student.Name,
                    course = courses
                })
                .SelectMany(result => result.course.DefaultIfEmpty(), (student, course) => new
                {
                    StudentName = student.stu,
                    CourseName = course?.CourseName ?? "No Course"
                }).ToList();
            foreach (var student in studentsLeftJoin)
            {
                Console.WriteLine($"{student.StudentName} - {student.CourseName}");
            }
            
            // Cross Join
            Console.WriteLine("\n" + "Cross Join");
            var studentsCrossJoin = new Student().GetAllStudents()
                .SelectMany(student => new Course().GetAllCourses(), (student, course) => new
                {
                    StudentName = student.Name,
                    CourseName = course.CourseName
                });
            foreach (var student in studentsCrossJoin)
            {
                Console.WriteLine(student.StudentName + " - " +  student.CourseName);
            }

            // Cross Join Alternative
            Console.WriteLine("\n" + "Cross Join Alternative");
            var studentsCrossJoinAlternative = new Student().GetAllStudents()
                .Join(new Course().GetAllCourses(), student => true, course => true, (student, course) => new
                {
                    StudentName = student.Name,
                    course.CourseName
                });
            foreach (var student in studentsCrossJoinAlternative)
            {
                Console.WriteLine(student.StudentName + " - " + student.CourseName);
            }

        }
    }
}
