using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern.StructuralPatterns.DecoratorDesignPattern
{
    public abstract class CoffeeDecorator : ICoffe
    {

        protected ICoffe _coffee;

        protected CoffeeDecorator(ICoffe coffe)
        {
            _coffee = coffe;
        }

        public virtual double GetCost()
        {
            return _coffee.GetCost();
        }

        public virtual string GetDescription()
        {
            return _coffee.GetDescription();
        }
    }
}
