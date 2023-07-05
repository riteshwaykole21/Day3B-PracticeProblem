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
            Console.WriteLine("2 : Access Modifier Demo");
            Console.WriteLine("Enter A Option");
            int Option = Convert.ToInt32(Console.ReadLine());
            switch(Option)
            {
                case 1:
                    new Constructors();
                    new Constructors(10,20);
                    break;
                case 2:
                    AccessModifier acc = new AccessModifier();
                    acc.Numbers(10,20);
                    acc.Numb(50, 60);
                    break;
            }
            Console.ReadLine();
        }
    }
}
