using CommandDesignPattern.Interfaces;

namespace CommandDesignPattern.Invoker
{
    public class InvokerClass
    {
        private ICommand _command;
        public InvokerClass(ICommand command) 
        {
            _command = command;
        }

        public void InvokeCommand()
        {
            _command.Execute();
        }
    }
}
