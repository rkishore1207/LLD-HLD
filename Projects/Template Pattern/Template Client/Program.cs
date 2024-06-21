using Template_Design_Pattern;
using Template_Design_Pattern.ConcreteClasses;

namespace Template_Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AbstractDataAccessor<Category> category = new CategoryNames();
            AbstractDataAccessor<Product> product = new ProductNames();
            category.Run(2);
            product.Run(2);
        }
    }
}
