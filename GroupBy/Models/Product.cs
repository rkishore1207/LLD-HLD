namespace GroupBy.Models
{
    public class Product
    {
        public string Category { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public List<Product> GetAllProducts()
        {
            return new List<Product>
            {
                new Product { Category = "Electronics", Name = "Laptop", Price = 1200 },
                new Product { Category = "Electronics", Name = "Smartphone", Price = 800 },
                new Product { Category = "Home Appliance", Name = "Refrigerator", Price = 1500 },
                new Product { Category = "Home Appliance", Name = "Microwave", Price = 200 },
            };
        }
    }    
}
