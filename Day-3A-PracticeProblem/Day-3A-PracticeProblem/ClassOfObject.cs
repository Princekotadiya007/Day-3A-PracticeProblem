using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3A_PracticeProblem
{
    internal class ClassOfObject
    {
        public string Name;
        public int Age;
        // Class methods
        public void SayHello()
        {
            Console.WriteLine("Hello, my name is " + Name + " and I am " + Age + " years old.");
        }
    }
}
