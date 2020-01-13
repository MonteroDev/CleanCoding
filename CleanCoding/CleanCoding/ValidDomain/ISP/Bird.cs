using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCoding.ValidDomain.ISP
{
    internal class Bird : IAnimal, IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("I'm Flying");
        }

        public void Walk()
        {
            Console.WriteLine("I'm walking even swimming!");
        }

        public void Eat()
        {
            Console.WriteLine("I'm having some seeds");
        }

        public void Drink()
        {
            Console.WriteLine("I'm drinking a little bit of water!");
        }
    }
}
