namespace GroupBy.Models
{
    public class Customer
    {
        public string MembershipLevel { get; set; }
        public string Name { get; set; }
        public decimal TotalSpent { get; set; }

        public List<Customer> GetAllCustomer()
        {
            return new List<Customer>
            {
                new Customer { MembershipLevel = "Gold", Name = "Anna", TotalSpent = 1000 },
                new Customer { MembershipLevel = "Silver", Name = "Brian", TotalSpent = 500 },
                new Customer { MembershipLevel = "Gold", Name = "Claire", TotalSpent = 1500 },
                new Customer { MembershipLevel = "Bronze", Name = "Dan", TotalSpent = 300 },
            };
        }
    }
}
