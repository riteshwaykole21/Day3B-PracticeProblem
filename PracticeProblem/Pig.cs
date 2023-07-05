using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    interface Animal
    {
        void animalSound();
    }
    public class Pig : Animal   
    {
        public void animalSound()
        {
            Console.WriteLine("The Pig Says wee Wee");
        }
    }
}
