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
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}
