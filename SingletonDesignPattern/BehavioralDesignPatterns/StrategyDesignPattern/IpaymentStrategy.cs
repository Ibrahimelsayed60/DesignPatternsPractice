using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern.BehavioralDesignPatterns.StrategyDesignPattern
{
    public interface IpaymentStrategy
    {
        void pay(decimal amount);
    }
}
