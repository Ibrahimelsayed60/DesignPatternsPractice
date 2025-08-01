using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern.BuilderDesignPattern
{
    public class HouseDirector
    {
        private readonly IHouseBuilder _builder;

        public HouseDirector(IHouseBuilder builder)
        {
            _builder = builder;
        }

        public House BuildLuxuryHouse()
        {
            return _builder.BuildGarden().BuildSwimmingPool().BuildGarage().GetHouse();
        }

    }
}
