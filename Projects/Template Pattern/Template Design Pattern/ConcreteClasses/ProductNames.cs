namespace Template_Design_Pattern.ConcreteClasses
{
    public class ProductNames : AbstractDataAccessor<Product>
    {
        public override void Process(int top)
        {
            Console.WriteLine("Product Name :");
            for (int i = 0; i < top; i++)
            {
                Console.WriteLine(names[i].Name);
            }
        }

        public override void Select()
        {
            names.Add(new Product() { Name = "ADO" });
            names.Add(new Product() { Name = "Jira" });
            names.Add(new Product() { Name = "Git" });
            names.Add(new Product() { Name = "Project Management Tool" });
        }
    }
}
