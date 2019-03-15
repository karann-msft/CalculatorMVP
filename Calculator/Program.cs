using CalcHelper;
using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Add add = new Add();
            float c = add.AddNumbers(5, 6);
            Console.WriteLine(c);
            Multiply multiply = new Multiply();
            float d = multiply.MultiplyNumbers(5, 6);
            Console.WriteLine(d);
           
            
        }
    }
}
