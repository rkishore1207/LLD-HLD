namespace ChainOfResponsibilityDesignPattern
{
    public class ClientAuth
    {
        public AbstractHandler _handler;
        public ClientAuth(AbstractHandler handler)
        {
            _handler = handler;
        }

        public bool AccessUser(string userName, string password)
        {
            return _handler.Handle(userName, password);
        }
    }
}
