namespace ChainOfResponsibilityDesignPattern.ConcreteHandlers
{
    public class ConcretePassword : AbstractHandler
    {
        public override bool Handle(string userName, string password)
        {
            var values = SampleDatabase.Database;
            if (values[userName] != password)
            {
                Console.WriteLine("Password is not Match");
                return false;
            }
            return HandleNextHandler(userName, password);
        }
    }
}
