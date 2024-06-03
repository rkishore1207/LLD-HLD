using CommandDesignPattern.CommandObjects;
using CommandDesignPattern.Invoker;
using CommandDesignPattern.Receiver;

namespace Command_Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InvokerClass invoker = new InvokerClass(new SimpleCommand("Kishore"));
            invoker.InvokeCommand();
            invoker = new InvokerClass(new ComplexCommand("Complex",new ReceiverClass()));
            invoker.InvokeCommand();
        }
    }
}
