using Builder_Design_Pattern.Concrete_Builder;
using Builder_Design_Pattern.Interfaces;
using Builder_Design_Pattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Design_Pattern.Director
{
    public class DesktopDirector
    {
        private readonly IBuilder _builder;

        public DesktopDirector(IBuilder builder) 
        {
            _builder = builder;
        }

        public void CreateDesktop()
        {
            _builder.CreateMotherboard();
            _builder.CreateMonitor();
            _builder.CreateProcessor();
            _builder.CreateStorage();
            _builder.CreateMouse();
            _builder.CreateKeyboard();
            _builder.CreateGraphics();
        }

        public Desktop GetDesktop()
        {
            return _builder.GetDesktop();
        }
    }
}
