namespace GroupBy.Models
{
    public class Sale
    {
        public string Region { get; set; }
        public string ProductType { get; set; }
        public decimal SalesAmount { get; set; }

        public List<Sale> GetAllSales()
        {
            return new List<Sale>
            {
                new Sale { Region = "North", ProductType = "Electronics", SalesAmount = 300 },
                new Sale { Region = "South", ProductType = "Furniture", SalesAmount = 500 },
                new Sale { Region = "North", ProductType = "Furniture", SalesAmount = 700 },
                new Sale { Region = "North", ProductType = "Furniture", SalesAmount = 700 },
                new Sale { Region = "South", ProductType = "Electronics", SalesAmount = 400 },
            };
        }
    }
}
