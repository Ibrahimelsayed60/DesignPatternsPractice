using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern.BehavioralDesignPatterns.StrategyDesignPattern
{
    public class ApplePayStrategy : IpaymentStrategy
    {
        public void pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount} using apple pay");
        }
    }
}
