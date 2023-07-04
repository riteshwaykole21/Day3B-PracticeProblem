using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 : Constructor Demo");
            Console.WriteLine("Enter A Option");
            int Option = Convert.ToInt32(Console.ReadLine());
            switch(Option)
            {
                case 1:
                    new Constructors();
                    new Constructors(10,20);
                    break;
            }
            Console.ReadLine();
        }
    }
}
