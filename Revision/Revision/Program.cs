
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


//using System;

//public interface drawable
//{
//    void draw();
//}
//public class Rectangle : drawable
//{
//    public void draw()
//    {
//        Console.WriteLine("drawing Rectangle");
//    }
//}
//public class circle: drawable
//{
//    public void draw()
//    {
//        Console.WriteLine("drawing circle");
//    }
//}

//   public class testinterface
//    {
//    public static void Main()
//{
//        drawable d;
//        d=new Rectangle();
//        d.draw();
//        d=new circle(); 
//        d.draw();
//}
//}


//using System;

//namespace Revision
//{
//    public class program
//    {
//       public static void Main(string[] args)
//        {
//            //setting
//            student student = new student();
//            student.Id = "407";
//            student.Name = "srikanth";
//            student.Email = "b@gmail.com";

//            //getting
//            Console.WriteLine("Id=" + student.Id);
//        }
//    }
//}

//using System;
//public class Encapsulation
//{
//    public static void Main(string[] args)
//    {
//        try
//        {
//            int a = 10;
//            int b = 0;
//            int x = a / b;
//        }
//        catch (Exception e) { Console.WriteLine(e); }

//        Console.WriteLine("Rest of the code");
//    }
//}

//using System;

//public class list
//{
//    public static void Main(string[] args)
//    {
//        //creating list of strings
//      //  var names=new List<string>() {"sri", "ram", "reddy"};
//        var names=new List<string>();
//        names.Add("sri");
//        names.Add("ram");
//        names.Add("reddy");

//        //iterate through the list
//        foreach(var name in names)
//        {
//            Console.WriteLine(name);
//        }
//    }
//}

//using System;

//public class Stack
//{
//    public static void Main(string[] args)
//    {
//        Stack<string> names = new Stack<string>();
//        names.Push ("sri") ;
//        names.Push("ram");
//        names.Push("reddy");
//        names.Push("kanth");

//        foreach(string name in names)
//        {
//            Console.WriteLine(name);
//        }
//        Console.WriteLine("peek element:" + names.Peek());
//        Console.WriteLine("pop element:" + names.Pop());
//        Console.WriteLine("after pop,peek element:" + names.Peek());
//    }
//}

//using System;

//public class Queue
//{
//    public static void Main(string[] args)
//    {
//        Queue<string> names= new Queue<string>();
//        names.Enqueue("sri");
//        names.Enqueue("ram");
//        names.Enqueue("reddy");
//        names.Enqueue("kanth");

//        foreach(string name in names)
//        {
//            Console.WriteLine(name);
//        }
//        Console.WriteLine("peek element:"+names.Peek());
//        Console.WriteLine("Dequeue :"+names.Dequeue());
//        Console.WriteLine("after Dequeue:" + names.Peek());
//    }
//}

//using System;

//public class Hashset
//{
//    public static void Main(string[] args)
//    {
//        var names = new HashSet<string>();
//        names.Add("sri");
//        names.Add("ram");
//        names.Add("reddy");
//        names.Add("sri");


//    foreach(var name in names)
//        {
//            Console.WriteLine(name);
//        }
//    }
//}

using System;

public class LinkedList
{
    public static void Main(string[] args)
    {
        var names= new LinkedList<string>();
        names.AddLast("kanth");
        names.AddLast("reddy");
        names.AddLast("sri");
        names.AddFirst("sri");

        foreach(var name in names)
        {
            Console.WriteLine(name);
        }
    }
}