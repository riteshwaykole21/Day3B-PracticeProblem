using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    public class AccessModifier
    {
        public void Numbers(int a, int b)
        {
            int Sum = a + b;
            Console.WriteLine($"Public Acess Modifier Sum {Sum}");
        }
        private void Num()
        {
            int c = 20;
            int d = 50;
            int Summ = c + d;
            Console.WriteLine($"Private Acess Modifier Sum{Summ}");
        }
        internal void Numb(int k , int L)
        {
            int Su = k + L;
            Console.WriteLine($"Internal Acess Modifier Is Sum  {Su}");
        }
    }
}
