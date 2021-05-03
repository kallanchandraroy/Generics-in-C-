using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Program
    {
        private static void Main()
        {
            bool Equal = Calculator.AreEqual(1, 2);

            if(Equal)
            {
                Console.WriteLine("Equal");
            }
            else 
            {
                Console.WriteLine("Not Equal");
                Console.ReadLine();
            }
        }
    }

    public class Calculator
    {
        public static bool AreEqual(int Value1, int Value2)
        {
            return Value1 == Value2;
        }
    }

}
