using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCoding.ValidDomain.ISP
{
    internal class Lion : IAnimal
    {
        public void Walk()
        {
            Console.WriteLine("I'm walking");
        }

        public void Eat()
        {
            Console.WriteLine("I'm eating");
        }

        public void Drink()
        {
            Console.WriteLine("I'm drinking");
        }
    }
}
