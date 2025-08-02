using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern.StructuralPatterns.BridgeDesignPattern
{
    public class SmsMessage:Message
    {

        public SmsMessage(IMessageRenderer renderer):base(renderer) 
        {
            
        }

        public override void show()
        {
            _renderer.Render("This is an sms Message");
        }

    }
}
