using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern.BehavioralDesignPatterns.StrategyDesignPattern
{
    public class PaymentProcessor
    {
        private IpaymentStrategy _strategy;

        public PaymentProcessor(IpaymentStrategy strategy)
        {
            _strategy = strategy;
        }

        public void SetPaymentStrategy(IpaymentStrategy strategy)
        {
            _strategy = strategy;
        }

        public void ProcessPayment(decimal amount)
        {
            _strategy.pay(amount);
        }

    }
}
