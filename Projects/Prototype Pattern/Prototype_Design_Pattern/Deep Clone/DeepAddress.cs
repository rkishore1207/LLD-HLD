

namespace Prototype_Design_Pattern.Deep_Clone
{
    public class DeepAddress : ICloneable
    {
        public string State { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
