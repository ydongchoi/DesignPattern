using DesignPattern.CreationalDesignPatterns.FactoryMethod.CarFactories;
using DesignPattern.CreationalDesignPatterns.FactoryMethod.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace DesignPattern.CreationalDesignPatterns.FactoryMethod
{
    public class Car
    {
        private readonly Dictionary<CarType, CarFactory> _carFactories;

        public Car()
        {
            _carFactories = new Dictionary<CarType, CarFactory>();

            foreach (CarType carType in Enum.GetValues(typeof(CarType)))
            {
                var factory = (CarFactory)Activator.CreateInstance(Type.GetType("DesignPattern." + "CreationalDesignPatterns." + "FactoryMethod." + "CarFactories." + Enum.GetName(typeof(CarType), carType) + "Factory"));
                _carFactories.Add(carType, factory);
            }
        }

        public static Car InitializeFactories() => new Car();
        public ICar ExecuteCreation(CarType carType, int velocity) => _carFactories[carType].Create(velocity);
    }
}
