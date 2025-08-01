using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern.AbstractFactoryDesignPattern
{
    public class MacButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Render Mac Button");
        }
    }
}
