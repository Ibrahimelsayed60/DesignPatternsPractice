using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern.StructuralPatterns.BridgeDesignPattern
{
    public class DarkThemeRenderer : IMessageRenderer
    {
        public void Render(string content)
        {
            Console.WriteLine($"[Dark Theme] {content}");
        }
    }
}
