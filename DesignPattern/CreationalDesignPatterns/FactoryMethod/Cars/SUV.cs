using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CreationalDesignPatterns.FactoryMethod.Cars
{
    public class SUV : ICar
    {
        private readonly int _velocity;
        public SUV(int velocity)
        {
            _velocity = velocity;
        }

        public void Drive()
        {
            Console.WriteLine($"SUV runs at {_velocity} km/h");
        }
    }
}
