using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern.BuilderDesignPattern
{
    public class House
    {

        public bool HasGarden { get; set; }

        public bool HasSwimmingPool { get; set; }

        public bool HasGarage { get; set; }

        public void ShowDetails()
        {
            Console.WriteLine($"House with Garden: {HasGarden}, Pool: {HasSwimmingPool}, Garage: {HasGarage}");
        }

    }
}
