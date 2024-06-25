using DesignPattern.CreationalDesignPatterns.FactoryMethod.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CreationalDesignPatterns.FactoryMethod.CarFactories
{
    public class SedanFactory : CarFactory
    {
        public override ICar Create(int velocity) => new Sedan(velocity);
    }
}
