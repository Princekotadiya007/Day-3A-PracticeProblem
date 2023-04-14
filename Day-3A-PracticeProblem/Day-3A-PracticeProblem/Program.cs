using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3A_PracticeProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {

                Console.WriteLine(" Plase enter the option");
                Console.WriteLine("Select Option 1");
                Console.WriteLine("Select Option 2");
                Console.WriteLine("Select Option 3");
                Console.WriteLine("Select Option 4");
                Console.WriteLine("Select Option 5");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:

                        ClassOfObject person1 = new ClassOfObject(); // Creating object

                        person1.Name = "prince";
                        person1.Age = 23;

                        person1.SayHello();
                        break;

                    case 2:
                        Dog dog = new Dog();
                        dog.Eat();
                        dog.Bark();
                        break;
                    case 3:
                        Polymorphism obj = new Polymorphism();
                        obj.Add(10, 20);
                        obj.Add(10.5f, 20.5f);
                        obj.Add("prince", "kotadiya");
                        break;
                    case 4:
                        Encapsulation account = new Encapsulation("12345", 1000);
                        account.Deposit(500);
                        account.Withdraw(2000);
                        account.Withdraw(1000);
                        account.DisplayBalance();
                        break;
                    case 5:
                        int a = 10;  // value type
                        int b = a;   // value type
                        a = 20;
                        Console.WriteLine($"a = {a}, b = {b}");
                        ValueTypeAndReferenceType p1 = new ValueTypeAndReferenceType { X = 10, Y = 20 };  // value type
                        ValueTypeAndReferenceType p2 = p1;                           // value type
                        p1.X = 30;
                        Console.WriteLine($"p1.X = {p1.X}, p2.X = {p2.X}");
                        Person person = new Person { Name = "prince", Age = 23 };  // reference type
                        Person personobj = person;                               // reference type
                        person.Age = 40;
                        Console.WriteLine($"person1.Age = {person.Age}, person2.Age = {personobj.Age}");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}
