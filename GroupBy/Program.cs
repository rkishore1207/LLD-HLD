using GroupBy.Models;

namespace GroupBy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1. Group Products by Category
            Scenario: Suppose you have a list of products, and each product has properties like Category, Name, and Price.
            Task: Group the products by Category and display the total count of products in each category*/

            var products = new Product().GetAllProducts().GroupBy(product => product.Category).ToList();

            foreach (var product in products) 
            {
                Console.WriteLine(product.Key + " - " + product.Count());
            }

            /*
             4. Group Transactions by Year and Month
            Scenario: You have a list of transactions, each with properties like TransactionDate, Amount, and Description.
            Task: Group the transactions by year and month of TransactionDate, and show the total amount for each period.
            */

            var transactions = new Transaction().GetAllTransaction()
                .GroupBy(transaction => new { transaction.TransactionDate.Year, transaction.TransactionDate.Month })
                .Select(x => new
                {
                    x.Key.Year,
                    x.Key.Month,
                    TotalAmount = x.Sum(x => x.Amount)
                }).ToList();

            foreach (var transaction in transactions) 
            {
                Console.WriteLine(transaction.Year + " - " + transaction.Month + " - " + transaction.TotalAmount);
            }

            /*
             *9. Group Customers by Membership Level and Calculate Total Spent
            Scenario: You have a list of customers, where each customer has a MembershipLevel (e.g., Gold, Silver, Bronze) and a TotalSpent.
            Task: Group customers by MembershipLevel and calculate the sum of TotalSpent for each level.
            */

            var customers = new Customer().GetAllCustomer().GroupBy(customer => customer.MembershipLevel).ToList();

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Key + " - " + customer.Sum(x => x.TotalSpent));
            }

            /*
             11. Group Sales by Product and Get Top 3 Sales Amounts
            Scenario: You have a list of sales entries where each entry includes a ProductName and SalesAmount.
            Task: Group sales by ProductName and get the top 3 highest SalesAmount entries within each product group.
            */

            Console.WriteLine("\n");
            var sales = new ProductSale().GetAllProductSales().GroupBy(sale => sale.ProductName)
                .Select(product => new 
                {
                    Name = product.Key,
                    Amount = product.OrderByDescending(x => x.SalesAmount).Take(3)
                }).ToList();

            foreach (var product in sales)
            {
                Console.WriteLine($"Product Group - {product.Name}");
                foreach (var sale in product.Amount)
                {
                    Console.WriteLine($"{sale.ProductName} - {sale.SalesAmount}");
                }
            }

            /*
             6. Group Sales by Region and Product Type
            Scenario: You have a list of sales records, where each record includes properties like Region, ProductType, and SalesAmount.
            Task: Group sales records by Region and ProductType to calculate the total sales amount in each region-product type combination.
             */

            Console.WriteLine("\n");
            var productSales = new Sale().GetAllSales()
                .GroupBy(sale => new { sale.Region, sale.ProductType })
                .Select(x => new
                {
                    x.Key.Region,
                    x.Key.ProductType,
                    Amount = x.Sum(y => y.SalesAmount)
                }).OrderBy(x => x.Region).ThenBy(y => y.ProductType).ToList();

            foreach (var sale in productSales)
            {
                Console.WriteLine($"{sale.Region} - {sale.ProductType} - {sale.Amount}");
            }
        }
    }
}
