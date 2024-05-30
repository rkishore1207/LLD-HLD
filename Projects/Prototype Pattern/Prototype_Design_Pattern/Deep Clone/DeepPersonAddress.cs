

namespace Prototype_Design_Pattern.Deep_Clone
{
    public class DeepPersonAddress(string name, int age, DeepAddress deepAddress):ICloneable
    {
        public string Name { get; set; } = name;
        public int Age { get; set; } = age;
        public DeepAddress Address { get; set; } = new DeepAddress() { City = deepAddress.City, State = deepAddress.State };
        public object Clone()
        {
            DeepPersonAddress deepPersonAddress = (DeepPersonAddress)this.MemberwiseClone();
            deepPersonAddress.Address = (DeepAddress)this.Address.Clone();
            return deepPersonAddress;
        }
    }
}
