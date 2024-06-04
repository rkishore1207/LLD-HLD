namespace ChainOfResponsibilityDesignPattern
{
    public abstract class AbstractHandler
    {
        private AbstractHandler? _handler;
        public AbstractHandler SetNextHandler(AbstractHandler handler)
        {
            _handler = handler;
            return _handler;
        }

        public abstract bool Handle(string userName, string password);
        public bool HandleNextHandler(string userName, string password)
        {
            if(_handler == null)
                return true;
            return _handler.Handle(userName, password);
        }
    }
}
