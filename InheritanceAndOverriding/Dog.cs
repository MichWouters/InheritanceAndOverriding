using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndOverriding
{
    // Inheritance, A is a X - relationship
    internal sealed class Dog: Animal
    {
        public string Breed { get; set; }

        // Constructor Inheritance -> If a base constructor requests params,
        // then these must also be probided in the derived classes
        public Dog(int id, string name, int age, Gender sex, string breed)
            : base(id, name, age, sex)
        {
            Breed = breed;
        }

        // This method is only available in Dog. See is - as as how to get access to this method
        public void ChaseTail()
        {
            Console.WriteLine("Wheeee. Look at him go");
        }

        public override string GetNoise()
        {
            return "Woof woof";
        }

        // Overriden methods can be overriden again and / or expanded upon
        public override string ToString()
        {
            return $"{base.ToString()} Breed: {Breed}";
        }
    }
}
