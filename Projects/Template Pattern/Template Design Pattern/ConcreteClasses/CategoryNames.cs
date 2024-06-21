namespace Template_Design_Pattern.ConcreteClasses
{
    public class CategoryNames : AbstractDataAccessor<Category>
    {
        public override void Process(int top)
        {
            Console.WriteLine("Category Name :");
            for (int i = 0; i < top; i++)
            {
                Console.WriteLine(names[i].Name);
            }
        }

        public override void Select()
        {
            names.Add(new Category() { Name = "UserStory" });
            names.Add(new Category() { Name = "Features" });
            names.Add(new Category() { Name = "Epic" });
            names.Add(new Category() { Name = "Bug" });
        }
    }
}
