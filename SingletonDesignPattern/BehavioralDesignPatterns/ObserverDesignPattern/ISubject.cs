using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern.BehavioralDesignPatterns.ObserverDesignPattern
{
    public interface ISubject
    {
        void Attach(Iobserver observable);
        void Detach(Iobserver observer);

        void Notify(string message);

    }
}
