using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndOverriding
{
    internal class Cat: Animal
    {
        public void Purr()
        {
            Console.WriteLine("Purrrrrr");
        }

        //public override string GetNoise()
        //{
        //    return "Meow";
        //}
    }
}
