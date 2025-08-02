using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern.BehavioralDesignPatterns.ObserverDesignPattern
{
    public class SmsSubscriber : Iobserver
    {
        private  string _phone;

        public SmsSubscriber(string phone)
        {
            _phone = phone;
        }

        public void update(string message)
        {
            Console.WriteLine($"Sms to {_phone}:{message}");
        }
    }
}
