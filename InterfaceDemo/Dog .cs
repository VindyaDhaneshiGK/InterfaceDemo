using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    public  class Dog : Animal
    {
        public void Eat()
        {
            Console.WriteLine("Kibble");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }
}
