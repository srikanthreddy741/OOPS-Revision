
////[Inheritance]

//using System;

//public class Animal
//{
//    public void eat()
//    {
//        Console.WriteLine("Eating");
//    }
//}

//public class Dog : Animal
//{
//    public void bark()
//    {
//        Console.WriteLine("Barking");
//    }
//}

//public class inheritence
//{
//    public static void Main(string[] args)
//    {
//        Dog d1 = new Dog();
//        d1.eat();
//        d1.bark();
//    }
//}

using System;


public class call
{
    public static int add(int a, int b)
    {
        return a + b;
    }
    public static int add(int a, int b, int c)
    {
        return a + b + c;
    }
}

public class methodoverloading
{
    public static void Main()
    {
        Console.WriteLine(call.add(20, 48));
        Console.WriteLine(call.add(15, 43, 65));
    }
}