using Builder_Design_Pattern.Interfaces;
using Builder_Design_Pattern.Model;

namespace Builder_Design_Pattern.Concrete_Builder
{
    public class HPBuilder : IBuilder
    {
        private readonly Desktop _desktop;
        public HPBuilder() 
        {
            _desktop = new Desktop();
        }
        public override void CreateGraphics()
        {
            _desktop.Graphics = "Created HP Graphics";
        }

        public override void CreateKeyboard()
        {
            _desktop.Keyboard = "Created HP Keyboard";
        }

        public override void CreateMonitor()
        {
            _desktop.Monitor = "Created HP Monitor";
        }

        public override void CreateMotherboard()
        {
            _desktop.Motherboard = "Created HP Motherboard";
        }

        public override void CreateMouse()
        {
            _desktop.Mouse = "Created HP Mouse";
        }

        public override void CreateProcessor()
        {
            _desktop.Processor = "Created HP Processor";
        }

        public override void CreateStorage()
        {
            _desktop.Storage = "Created HP Storage";
        }

        public override Desktop GetDesktop()
        {
            return _desktop;
        }
    }
}
