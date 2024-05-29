using Builder_Design_Pattern.Interfaces;
using Builder_Design_Pattern.Model;

namespace Builder_Design_Pattern.Concrete_Builder
{
    public class AsusBuilder : IBuilder
    {
        private readonly Desktop _desktop;
        public AsusBuilder() 
        {
            _desktop = new Desktop();
        }
        public override void CreateGraphics()
        {
            _desktop.Motherboard = "Created Asus Graphics";
        }

        public override void CreateKeyboard()
        {
            _desktop.Keyboard = "Created Asus Keyboard";
        }

        public override void CreateMonitor()
        {
            _desktop.Monitor = "Created Asus Monitor";
        }

        public override void CreateMotherboard()
        {
            _desktop.Motherboard = "Created Asus Motherboard";
        }

        public override void CreateMouse()
        {
            _desktop.Mouse = "Created Asus Mouse";
        }

        public override void CreateProcessor()
        {
            _desktop.Processor = "Created Asus Processor";
        }

        public override void CreateStorage()
        {
            _desktop.Storage = "Created Asus Storage";
        }

        public override Desktop GetDesktop()
        {
            return _desktop;
        }
    }
}
