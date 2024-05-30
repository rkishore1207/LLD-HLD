using Builder_Design_Pattern.Model;

namespace Builder_Design_Pattern.Interfaces
{
    public abstract class  IBuilder
    {
        public abstract void CreateMotherboard();
        public abstract void CreateMonitor();
        public abstract void CreateKeyboard();
        public abstract void CreateProcessor();
        public abstract void CreateMouse();
        public abstract void CreateStorage();
        public abstract void CreateGraphics();
        public virtual Desktop GetDesktop()
        {
            Desktop desktop = new Desktop();
            return desktop;
        }
    }
}
