using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class MallardDuck : Duck
    {
        override public void display() 
        {
            Console.WriteLine("Mallard duck");
        }
    }
}
