// using System;

// // Concept of Inheritance
// // Inheritance allows one class to reuse the properties and methods of another class.
// // The class being inherited from is called the Base Class (Parent)
// // The class that inherits is called the Derived Class (Child)

// // Creating Inheritance
// // Inheritance is created using the colon (:) symbol.
// class Vehicle
// {
//     public void Start()
//     {
//         Console.WriteLine("Vehicle started");
//     }
// }

// class Car : Vehicle
// {
//     public void Drive()
//     {
//         Console.WriteLine("Car is driving");
//     }
// }

// class Person
// {
//     public string Name;

//     public Person(string name)
//     {
//         Name = name;
//     }
// }

// class Student : Person
// {
//     public int RollNo;

//     public Student(string name, int roll) : base(name)
//     {
//         RollNo = roll;
//     }
// }

// // Single Inheritance
// // One base class, one derived class.
// class Animal
// {
//     public void Eat()
//     {
//         Console.WriteLine("Animal eats");
//     }
// }

// class Dog : Animal
// {
//     public void Bark()
//     {
//         Console.WriteLine("Dog barks");
//     }
// }

// // Multilevel Inheritance
// // A class is derived from another derived class.
// class LivingBeing
// {
//     public void Breathe()
//     {
//         Console.WriteLine("Breathing");
//     }
// }

// class Human : LivingBeing
// {
//     public void Think()
//     {
//         Console.WriteLine("Thinking");
//     }
// }

// class Employee : Human
// {
//     public void Work()
//     {
//         Console.WriteLine("Working");
//     }
// }


// // Using Interface solves the Diamond problem
// interface IPrintable
// {
//     void Print();
// }

// interface IScannable
// {
//     void Scan();
// }

// class Machine : IPrintable, IScannable
// {
//     public void Print()
//     {
//         Console.WriteLine("Printing");
//     }

//     public void Scan()
//     {
//         Console.WriteLine("Scanning");
//     }
// }

// // Method Overriding
// // A derived class can modify the behavior of a base class method.
// // Base Class
// class Animal
// {
//     public virtual void Sound()
//     {
//         Console.WriteLine("Animal makes sound");
//     }
// }
// // Derived Class
// class Dog : Animal
// {
//     public override void Sound()
//     {
//         Console.WriteLine("Dog barks");
//     }
// }

// // Sealed Classes and Methods
// // Sealed Class
// // Prevents inheritance.
// // Sealed classes act as the "final version" of a class, ensuring that its logic cannot be altered or extended by any other class.
// // sealed class Security { }

// // Sealed Method
// // Prevents overriding.
// // A sealed method prevents further subclasses from changing the behavior of an inherited method.
// class Parent
// {
//     public virtual void Show() { }
// }

// class Child : Parent
// {
//     public sealed override void Show() { }
// }

// class Parent
// {
//     public virtual void Show()
//     {
//         Console.WriteLine("Parent Show");
//     }
// }

// class Child : Parent
// {
//     public sealed override void Show()
//     {
//         Console.WriteLine("Child Show");
//     }
// }

// class GrandChild : Child
// {
//     public override void Show()   // Compile-time error
//     {
//     }
// }


// // Compostion

// class Engine
// {
//     public void Start()
//     {
//         Console.WriteLine("Engine started");
//     }
// }

// class Car
// {
//     Engine engine = new Engine();

//     public void Drive()
//     {
//         engine.Start();
//         Console.WriteLine("Car is driving");
//     }
// }

// // Method Hiding

// class Parent
// {
//     public void Show()
//     {
//         Console.WriteLine("Parent Show");
//     }
// }


// class Child : Parent
// {
//     public new void Show()
//     {
//         Console.WriteLine("Child Show");
//     }
// }

// // Static Method

// class A
// {
//     public static void Display()
//     {
//         Console.WriteLine("A Display");
//     }
// }

// class B : A
// {
//     public new static void Display()
//     {
//         Console.WriteLine("B Display");
//     }
// }