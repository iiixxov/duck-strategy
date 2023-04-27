using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            MallardDuck duck = new MallardDuck();
            duck.display();
            duck.swim();
            duck.quack();

        }
    }
}
