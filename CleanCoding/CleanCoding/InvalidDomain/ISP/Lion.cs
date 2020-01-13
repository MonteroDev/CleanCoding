using System;

namespace CleanCoding.InvalidDomain.ISP
{
    internal class Lion : IAnimal
    {
        public void Fly()
        {
            throw new NotImplementedException();
        }

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
