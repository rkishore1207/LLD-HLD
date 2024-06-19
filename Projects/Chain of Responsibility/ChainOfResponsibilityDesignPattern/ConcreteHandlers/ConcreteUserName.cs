namespace ChainOfResponsibilityDesignPattern.ConcreteHandlers
{
    public class ConcreteUserName : AbstractHandler
    {
        public override bool Handle(string userName, string password)
        {
            var values = SampleDatabase.Database;
            if (!values.ContainsKey(userName))
            {
                Console.WriteLine("User Not Found");
                return false;
            }
            return HandleNextHandler(userName,password);
        }
    }
}
