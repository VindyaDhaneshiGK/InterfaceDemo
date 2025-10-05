using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    public class Cat: Animal
    {
        public void Eat()
        {
            Console.WriteLine("Tuna");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }
}
