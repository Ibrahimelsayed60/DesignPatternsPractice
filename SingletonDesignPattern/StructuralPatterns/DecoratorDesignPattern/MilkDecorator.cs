using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern.StructuralPatterns.DecoratorDesignPattern
{
    public class MilkDecorator : CoffeeDecorator
    {
        public MilkDecorator(ICoffe coffe):base(coffe) 
        {
            
        }

        public override string GetDescription()
        {
            return base.GetDescription() + ",Milk";
        }

        public override double GetCost()
        {
            return base.GetCost() + 5.0;
        }

    }
}
