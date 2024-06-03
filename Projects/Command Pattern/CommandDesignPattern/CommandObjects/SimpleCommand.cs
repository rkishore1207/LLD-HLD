using CommandDesignPattern.Interfaces;

namespace CommandDesignPattern.CommandObjects
{
    public class SimpleCommand : ICommand
    {
        public string Input { get; set; } = string.Empty;
        public SimpleCommand(string input)
        {
            Input = input;
        }
        public void Execute()
        {
            Console.WriteLine("Simple Command Execution: " + Input);
        }
    }
}
