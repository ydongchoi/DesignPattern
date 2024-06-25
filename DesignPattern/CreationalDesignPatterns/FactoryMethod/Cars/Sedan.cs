using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CreationalDesignPatterns.FactoryMethod.Cars
{
    public class Sedan : ICar
    {
        private readonly int _velocity;
        public Sedan(int velocity)
        {
            _velocity = velocity;
        }

        public void Drive()
        {
            Console.WriteLine($"Sedan runs at {_velocity} km/h");
        }
    }
}
