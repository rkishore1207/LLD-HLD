
using Prototype_Design_Pattern.Shallow_Clone;

namespace Prototype_Design_Pattern.Products
{
    public class PersonAddress(string name, int age, Address address) : ICloneable 
    {
        public string Name { get; set; } = name;
        public int Age { get; set; } = age;
        public Address Address { get; set; } = new Address() { City = address.City, State = address.State};
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
