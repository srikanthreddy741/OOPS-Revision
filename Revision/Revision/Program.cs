
//[Inheritance]

using System;

public class Animal
{
    public void eat()
    {
        Console.WriteLine("Eating");
    }
}

public class Dog : Animal
{
    public void bark()
    {
        Console.WriteLine("Barking");
    }
}

public class inheritence
{
    public static void Main(string[] args)
    {
        Dog d1 = new Dog();
        d1.eat();
        d1.bark();
    }
}