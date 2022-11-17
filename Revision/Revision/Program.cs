
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

//using System;


//public class call
//{
//    public static int add(int a, int b)
//    {
//        return a + b;
//    }
//    public static int add(int a, int b, int c)
//    {
//        return a + b + c;
//    }
//}

//public class methodoverloading
//{
//    public static void Main()
//    {
//        Console.WriteLine(call.add(20, 48));
//        Console.WriteLine(call.add(15, 43, 65));
//    }
//}

//using System;
//public class Animal
//{
//    public virtual void eat()
//    {
//        Console.WriteLine("Eating..");
//    }
//}
//    public  class Dog : Animal
//    {
//        public override void eat()
//        {
//            Console.WriteLine("Eating bread..");
//        }
//    }

//public class MethodOverriding
//{
//    public static void Main()
//    {
//        Dog d  = new Dog();
//        d.eat();
//    }
//}

//using System;
//using System.Drawing;

//public abstract class shape
//{
//    public abstract void draw();

//    }
//public class rectangle : shape
//{
//    public override void draw()
//    {
//     Console.WriteLine("rectangle shape");
//    }
//}
//public class Circle : shape
//{
//    public override void draw()
//    {
//        Console.WriteLine("drawing circle...");
//    }
//}
//public class TestAbstract
//{
//    public static void Main()
//    {
//        shape s;
//        s = new rectangle();
//        s.draw();
//        s = new Circle();
//        s.draw();
//    }
//}


using System;

public interface drawable
{
    void draw();
}
public class Rectangle : drawable
{
    public void draw()
    {
        Console.WriteLine("drawing Rectangle");
    }
}
public class circle: drawable
{
    public void draw()
    {
        Console.WriteLine("drawing circle");
    }
}

   public class testinterface
    {
    public static void Main()
{
        drawable d;
        d=new Rectangle();
        d.draw();
        d=new circle(); 
        d.draw();
}
}