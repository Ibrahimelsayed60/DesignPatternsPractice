using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern.StructuralPatterns.DecoratorDesignPattern
{
    public class CreamDecorator:CoffeeDecorator
    {

        public CreamDecorator(ICoffe coffe):base(coffe) 
        {
            
        }

        public override string GetDescription()
        {
            return base.GetDescription() + ",cream";
        }

        public override double GetCost()
        {
            return base.GetCost() + 7.0;
        }

    }
}
