using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    public class Animal : IAnimal
    {
          public void Eat()
        {
            Console.WriteLine("Animal is eating");

        }
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic animal sound");
        }
    }
}
