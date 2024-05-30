using Prototype_Design_Pattern.Deep_Clone;
using Prototype_Design_Pattern.Products;
using Prototype_Design_Pattern.Shallow_Clone;

namespace Prototype_Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Shallow Clone
            PersonAddress kishoreAddress = new PersonAddress("Kishore",21, new Address() { City = "Chennai", State = "TamilNadu"});
            Display(kishoreAddress,"Original");

            PersonAddress kishoreAddressClone = (PersonAddress)kishoreAddress.Clone();
            Display(kishoreAddressClone, "Clone");

            PersonAddress mathanAddress = new PersonAddress("Mathan", 22, new Address() { City = "Coimbatore", State = "Karnataka" });
            Display(mathanAddress, "Original");

            PersonAddress mathanAddressClone = (PersonAddress)mathanAddress.Clone();
            mathanAddressClone.Name = "Mathan Raj";
            mathanAddressClone.Age = 24;
            mathanAddressClone.Address.State = "TAmil nadu";
            mathanAddressClone.Address.City = "KovilPatti";
            Display(mathanAddressClone, "Clone");

            Display(mathanAddress, "Original");

            //Deep Clone
            Console.WriteLine("Deep Clone");
            DeepPersonAddress address1 = new DeepPersonAddress("Kishore", 21, new DeepAddress() { City = "Chennai", State = "TamilNadu" });
            Display(address1, "Original");

            DeepPersonAddress address1Clone = (DeepPersonAddress)address1.Clone();
            address1Clone.Address.State = "Kerala";
            address1Clone.Address.City = "Cochin";
            Display(address1Clone, "Clone");

            Display(address1, "Original");
        }

        private static void Display(PersonAddress address, string type)
        {
            Console.WriteLine(type + '\n' +
                               address.Name + '\n' +
                               address.Age + '\n' +
                               address.Address.City + '\n' +
                               address.Address.State + '\n');
        }

        private static void Display(DeepPersonAddress address, string type)
        {
            Console.WriteLine(type + '\n' +
                               address.Name + '\n' +
                               address.Age + '\n' +
                               address.Address.City + '\n' +
                               address.Address.State + '\n');
        }
    }
}
