using DesignPattern.CreationalDesignPatterns.FactoryMethod.Cars;

namespace DesignPattern.CreationalDesignPatterns.FactoryMethod.CarFactories
{
    public abstract class CarFactory
    {
        public abstract ICar Create(int velocity);
    }
}
