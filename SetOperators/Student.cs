namespace SetOperators
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public List<Student> GetAllStudents()
        {
            return new List<Student>
            {
                new Student 
                {
                    Id = 1,
                    Name = "Jon Snow",
                    Age = 27
                },
                new Student
                {
                    Id = 2,
                    Name = "Danearys",
                    Age = 26
                },
                new Student
                {
                    Id = 3,
                    Name = "Tyrion",
                    Age = 28
                },
                new Student
                {
                    Id = 3,
                    Name = "Tyrion",
                    Age = 28
                }
            };
        }

        //public override bool Equals(object obj)
        //{
        //    return Id == ((Student)obj).Id && Name == ((Student)obj).Name;
        //}

        //public override int GetHashCode()
        //{
        //    return Id.GetHashCode() ^ Name.GetHashCode();
        //}
    }
}
