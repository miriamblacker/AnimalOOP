using AnimalVeriSoft;

void InitAnimal(Animal[] zoo)
{

    for (int i = 0; i < zoo.Length; i++)
    {
        if (i % 3 == 0)
        {
            zoo[i] = new Dog();
        }
        else if (i % 2 == 0)
        {
            zoo[i] = new Frog();
        }
        else
        {
            zoo[i] = new Cat();
        }
    }

}

void TestAnimal(Animal[] zoo)
{
    foreach (var animal in zoo)
    {

        animal.SayHello();
        animal.SayHello(Animal.MOOD_SCARE);
        animal.SayHello(Animal.MOOD_HAPPY);

        Console.WriteLine("Mammal: " + animal.IsMammal());
        Console.WriteLine("Carnivorus: " + animal.IsCarnivorous());

        if (animal is Cat)
        {
            Console.WriteLine("Hi, I'm a cat &:");
            Console.WriteLine("Number of my legs: " + (animal as Cat).GetNumberOfLegs());
        }
        else if (animal is Dog)
        {
            Console.WriteLine("Hi, I'm a dog &:");
            Console.WriteLine("Number of my legs: " + (animal as Dog).GetNumberOfLegs());
        }
        else if (animal is Frog)
        {
            Console.WriteLine("Hi, I'm a frog &:");
            Console.WriteLine("Number of my legs: " + (animal as Frog).GetNumberOfLegs());
            Console.WriteLine("Gills: " + (animal as Frog).HasGills());
            Console.WriteLine("Lays eggs: " + (animal as Frog).HasLaysEggs());
        }

        Console.WriteLine("-----------");

    }
}

Animal[] myZoo = new Animal[3];

InitAnimal(myZoo);

TestAnimal(myZoo);