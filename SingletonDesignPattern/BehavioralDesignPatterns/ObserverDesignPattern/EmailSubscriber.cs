using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern.BehavioralDesignPatterns.ObserverDesignPattern
{
    public class EmailSubscriber : Iobserver
    {
        private string _email;

        public EmailSubscriber(string email)
        {
            _email = email;
        }

        public void update(string message)
        {
            Console.WriteLine($"Email to {_email} : {message}");
        }
    }
}
