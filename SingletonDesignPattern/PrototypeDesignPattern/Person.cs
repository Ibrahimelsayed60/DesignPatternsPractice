using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern.PrototypeDesignPattern
{
    public class Person : IPrototype<Person>
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public Person Clone()
        {
            return (Person)this.MemberwiseClone();
        }

        public Person DeepClone()
        {
            return new Person
            {
                Name = Name,
                Age = Age,
            };
        }

    }
}
