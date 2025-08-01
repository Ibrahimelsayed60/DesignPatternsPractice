using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern.AbstractFactoryDesignPattern
{
    public class Application
    {
        private readonly IButton _button;
        public Application(IGUIFactory factory)
        {
            _button = factory.CreateButton();
        }

        public void Run()
        {
            _button.Render();
        }

    }
}
