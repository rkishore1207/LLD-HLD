using ObserverDesignPattern.Interfaces;

namespace ObserverDesignPattern.Implementations
{
    public class Subject : ISubject
    {
        public int State { get; set; } = 0;
        private List<IObserver> observers = new List<IObserver>();
        public Subject() { }
        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObserver()
        {
            foreach (var observer in observers)
                observer.Update(this);
        }

        public void BusinessImplementation()
        {
            State = new Random().Next(0,10);
            Console.WriteLine("Changed State value is " + State);
            NotifyObserver();
        }
    }
}
