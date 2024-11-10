namespace GroupBy.Models
{
    public class Transaction
    {
        public DateTime TransactionDate { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }

        public List<Transaction> GetAllTransaction()
        {
            return new List<Transaction>
            {
                new Transaction { TransactionDate = new DateTime(2023, 1, 5), Amount = 100, Description = "Groceries" },
                new Transaction { TransactionDate = new DateTime(2023, 1, 15), Amount = 200, Description = "Rent" },
                new Transaction { TransactionDate = new DateTime(2023, 2, 10), Amount = 150, Description = "Utilities" },
                new Transaction { TransactionDate = new DateTime(2023, 2, 20), Amount = 250, Description = "Insurance" },
            };
        }
    }
}
