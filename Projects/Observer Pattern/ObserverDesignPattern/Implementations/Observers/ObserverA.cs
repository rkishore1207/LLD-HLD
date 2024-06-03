using ObserverDesignPattern.Interfaces;

namespace ObserverDesignPattern.Implementations.Observers
{
    public class ObserverA : IObserver
    {
        public void Update(ISubject subject)
        {
            if(subject is Subject concreteSubject)
            {
                if (concreteSubject.State < 3)
                    Console.WriteLine("ObserverA Executed");
            }
        }
    }
}
