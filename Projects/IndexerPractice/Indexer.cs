

namespace IndexerPractice
{
    public class Indexer
    {
        public class Employee
        {
            public int EmployeeId { get; set; }
            public string Name { get; set; } = string.Empty;
            public string Gender { get; set; } = string.Empty;
        }

        public class Company
        {
            private readonly List<Employee> _employees;

            public Company()
            {
                _employees = new List<Employee>();
                _employees.Add(new Employee() { EmployeeId = 1, Name = "Dhoni", Gender = "Male" });
                _employees.Add(new Employee() { EmployeeId = 2, Name = "Virat", Gender = "Male" });
                _employees.Add(new Employee() { EmployeeId = 3, Name = "Rohith", Gender = "Male" });
            }

            public string this[int employeeId]
            {
                get => _employees.FirstOrDefault(emp => emp.EmployeeId == employeeId)?.Name.ToString();
                set => _employees.FirstOrDefault(emp => emp.EmployeeId == employeeId).Name = value;
            }
        }
    }
}
