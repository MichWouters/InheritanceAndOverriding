using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndOverriding
{
    public enum Gender
    {
        Unknown, Male, Female
    }

    // Abstract classes cannot be instantiated but can be inherited from.
    // Sealed classes cannot be inherited from but can be instantiated.
    internal abstract class Animal
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public Gender Sex{ get; set; }

        public Animal(int id, string name, int age, Gender sex)
        {
            Id = id;
            Name = name;
            Age = age;
            Sex = sex;
        }

        public override string ToString()
        {
            return $"Name: {Name }, Age: {Age}";
        }

        public void Eat()
        {
            Console.WriteLine($"Yum, {Name} is eating");
        }

        public virtual string GetNoise()
        {
            return "High pitched screeching";
        }
    }
}
