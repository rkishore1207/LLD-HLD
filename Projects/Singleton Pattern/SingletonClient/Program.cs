namespace SingletonClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SingletonPattern obj1 = SingletonPattern.GetSingleton();
            SingletonPattern obj2 = SingletonPattern.GetSingleton();
            if (obj1 == obj2)
                Console.WriteLine("Same Object");
            else
                Console.WriteLine("Different Object");
        }
    }
}
