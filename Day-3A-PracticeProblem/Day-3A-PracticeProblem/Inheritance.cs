﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Day_3A_PracticeProblem
{
    internal class Inheritance
    {
        // Class member (field)
        public string Name;

        // Class method
        public void Eat()
        {
            Console.WriteLine(Name + " is eating.");
        }
    }

    // Define a derived class called "Dog" that inherits from "Animal"
    class Dog : Inheritance
    {
        // Class method
        public void Bark()
        {
            Console.WriteLine(Name + " is barking.");
        }
    }
}

