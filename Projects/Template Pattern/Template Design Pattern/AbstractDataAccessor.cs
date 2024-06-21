namespace Template_Design_Pattern
{
    public abstract class AbstractDataAccessor<T>
    {
        protected List<T> names = new List<T>();

        public virtual void Connect()
        {
            names.Clear();
        }
        public abstract void Select();
        public abstract void Process(int top);
        public virtual void Disconnect()
        {
            names.Clear();
        }
        public void Run(int top)
        {
            Connect();
            Select();
            Process(top);
            Disconnect();
        }
    }
}
