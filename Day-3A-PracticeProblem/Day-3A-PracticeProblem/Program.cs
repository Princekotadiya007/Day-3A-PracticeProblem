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
            ClassOfObject person1 = new ClassOfObject();

            person1.Name = "prince";
            person1.Age = 23;

            person1.SayHello();
        }
    }
}
