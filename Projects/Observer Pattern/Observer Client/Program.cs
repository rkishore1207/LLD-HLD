using ObserverDesignPattern.Implementations;
using ObserverDesignPattern.Implementations.Observers;
using ObserverDesignPattern.Interfaces;

namespace Observer_Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var subject = new Subject();
            IObserver observerA = new ObserverA();
            subject.Attach(observerA);
            IObserver observerB = new ObserverB();
            subject.Attach(observerB);

            subject.BusinessImplementation();
            subject.Detach(observerB);

            subject.BusinessImplementation();
        }
    }
}
