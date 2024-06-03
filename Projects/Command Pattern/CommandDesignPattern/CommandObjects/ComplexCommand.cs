using CommandDesignPattern.Interfaces;
using CommandDesignPattern.Receiver;

namespace CommandDesignPattern.CommandObjects
{
    public class ComplexCommand : ICommand
    {
        private ReceiverClass _receiver;
        public string Input { get; set; } = string.Empty;
        public ComplexCommand(string input, ReceiverClass receiver)
        {
            Input = input;
            _receiver = receiver;
        }

        public void Execute()
        {
            _receiver.DoSomething(Input);
            _receiver.DoSomethingElse(Input);
        }
    }
}
