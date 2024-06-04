using ChainOfResponsibilityDesignPattern;
using ChainOfResponsibilityDesignPattern.ConcreteHandlers;

namespace ChainOfResponsibilityClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AbstractHandler handler = new ConcreteUserName().SetNextHandler(new ConcretePassword());
            ClientAuth client = new ClientAuth(handler);
            if (client.AccessUser("Kishohre", "ABCd%0987"))
                Console.WriteLine("Access Granted");
            else Console.WriteLine("Access Denied");
        }
    }
}
