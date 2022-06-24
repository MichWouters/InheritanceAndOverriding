using InheritanceAndOverriding;

List<Animal> animals = GenerateAnimals();
HandleAnimals(animals);

List<Animal> GenerateAnimals()
{
    Animal fido = new Dog(1, "Fido", 2, Gender.Male, "Labrador");
    Animal barky = new Dog(2, "Barky", 4, Gender.Male, "Pitbull");
    //Animal animal = new Animal(5, "Fpp", 4, Gender.Unknown);

    // These derived classes do not require a constructor, even though their base class needs one.
    Animal minou = new Cat
    {
        Id = 3,
        Age = 1,
        Name = "Minou",
        Sex = Gender.Female
    };

    Animal tony = new Tiger
    {
        Age = 24,
        Id = 4,
        Name = "Tony",
        Sex = Gender.Unknown
    };

    // Using inheritance and polymorphism, we can dramatically cut back on the amount of required code.
    List<Animal> animals = new List<Animal>();
    animals.Add(fido);
    animals.Add(barky);
    animals.Add(minou);
    animals.Add(tony);

    return animals;
}

void HandleAnimals(List<Animal> animals)
{
    // Polymorphism: Derived classes can take the shape of their
    // base classes and vice-versa
    foreach (Animal dier in animals)
    {
        dier.Eat();
        Console.WriteLine(dier.ToString());
        Console.WriteLine(dier.GetNoise());

        // AKA. TryParse -> Can I convert you to X?
        if (dier is Dog)
        {
            Dog dog = (Dog)dier;
            dog.ChaseTail();
        }

        // Same logic as Is. Only slightly different Syntax
        Dog hond = dier as Dog;
        if (hond != null)
        {
            hond.ChaseTail();
        }

        Console.WriteLine();
    }
}

Console.ReadLine();