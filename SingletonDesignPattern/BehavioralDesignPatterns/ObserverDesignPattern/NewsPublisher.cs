using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern.BehavioralDesignPatterns.ObserverDesignPattern
{
    public class NewsPublisher : ISubject
    {
        private List<Iobserver> _observers = new List<Iobserver>();

        public void Attach(Iobserver observable)
        {
            _observers.Add(observable);
        }

        public void Detach(Iobserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify(string message)
        {
            foreach (Iobserver observer in _observers)
            {
                observer.update(message);
            }
        }

        public void PublishNews(string message)
        {
            Console.WriteLine($"Publisher: {message}");
            Notify(message);
        }
    }
}
