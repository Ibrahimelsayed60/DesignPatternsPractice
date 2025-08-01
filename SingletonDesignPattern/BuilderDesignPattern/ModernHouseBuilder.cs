using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern.BuilderDesignPattern
{
    public class ModernHouseBuilder : IHouseBuilder
    {
        private House _house = new House();
        public IHouseBuilder BuildGarden()
        {
            _house.HasGarden = true;
            return this;
        }

        public IHouseBuilder BuildSwimmingPool()
        {
            _house.HasSwimmingPool = true;
            return this;
        }

        public House GetHouse()
        {
            return _house;
        }

        public IHouseBuilder BuildGarage()
        {
            _house.HasGarage = true;
            return this;
        }
    }
}
