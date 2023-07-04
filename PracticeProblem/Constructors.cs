using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    public class Constructors
    {
        public int a;
        public int b;   
        // This is Un Parameterrised Constructor
        public Constructors()
        {
            Console.WriteLine("This Is Parameter Less Constructor");
        }
        // This Is Parameter rised Constructor
        public Constructors(int a ,int b)
        {
            int Sum = a + b;
            Console.WriteLine(Sum);
        }
    }
}
