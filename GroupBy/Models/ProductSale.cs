namespace GroupBy.Models
{
    public class ProductSale
    {
        public string ProductName { get; set; }
        public decimal SalesAmount { get; set; }

        public List<ProductSale> GetAllProductSales()
        {
            return new List<ProductSale>
            {
                new ProductSale { ProductName = "Laptop", SalesAmount = 200 },
                new ProductSale { ProductName = "Laptop", SalesAmount = 500 },
                new ProductSale { ProductName = "Tablet", SalesAmount = 300 },
                new ProductSale { ProductName = "Laptop", SalesAmount = 800 },
                new ProductSale { ProductName = "Tablet", SalesAmount = 400 },
            };
        }
    }
}
