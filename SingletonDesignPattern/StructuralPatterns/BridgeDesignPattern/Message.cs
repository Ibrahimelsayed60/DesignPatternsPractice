using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern.StructuralPatterns.BridgeDesignPattern
{
    public abstract class Message
    {

        protected IMessageRenderer _renderer;

        protected Message(IMessageRenderer renderer)
        {
            _renderer = renderer;
        }

        public abstract void show();

    }
}
