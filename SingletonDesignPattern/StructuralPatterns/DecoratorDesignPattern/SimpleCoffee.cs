using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern.StructuralPatterns.DecoratorDesignPattern
{
    public class SimpleCoffee : ICoffe
    {
        public double GetCost()
        {
            return 10.0;
        }

        public string GetDescription()
        {
            return "Simple Coffee";
        }
    }
}
