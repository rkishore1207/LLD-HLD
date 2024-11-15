namespace GroupJoin
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }

        public List<Student> GetAllStudents()
        {
            return new List<Student>
            {
                new Student { StudentId = 1, Name = "Bob" },
                new Student { StudentId = 2, Name = "Alice" },
                new Student { StudentId = 3, Name = "Charlie" }
            };
        }
    }
}
