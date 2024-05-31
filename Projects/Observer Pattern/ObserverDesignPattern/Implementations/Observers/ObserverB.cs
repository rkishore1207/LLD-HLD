
using ObserverDesignPattern.Interfaces;

namespace ObserverDesignPattern.Implementations.Observers
{
    public class ObserverB : IObserver
    {
        public void Update(ISubject subject)
        {
            if ((subject as Subject).State == 0 || (subject as Subject).State >= 3)
                Console.WriteLine("ObserverB Executed");
        }
    }
}
