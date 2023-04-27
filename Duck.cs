using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    abstract class Duck
    {
        public FlyBehavior flyBehavior;
        public void quack()
        {
            Console.WriteLine("quack() called");
        }
        public void swim()
        {
            Console.WriteLine("swim() called");
        }
        public abstract void display();
    }
}
