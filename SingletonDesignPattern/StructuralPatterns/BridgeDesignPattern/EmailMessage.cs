using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern.StructuralPatterns.BridgeDesignPattern
{
    public class EmailMessage:Message
    {
        public EmailMessage(IMessageRenderer renderer):base(renderer) 
        {
            
        }

        public override void show()
        {
            _renderer.Render("This is an Email Message");
        }
    }
}
