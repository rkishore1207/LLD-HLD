namespace SetOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var students = new Student().GetAllStudents();
            var uniqueStudents = students.Select(student => new
            {
                student.Id,
                student.Name
            }).Distinct();
            foreach (var student in uniqueStudents)
            {
                Console.WriteLine(student.Id + " - " + student.Name);
            }
        }
    }
}
