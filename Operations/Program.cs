using System;

namespace LearnCS
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter an number: ");
            int i =  Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a second number: ");
            int j = int.Parse(Console.ReadLine());
            int k = i + j;
            Console.WriteLine("Sum is: " + k);
            int l = i - j;
            Console.WriteLine("Sub is: " + l);
            int m = i * j;
            Console.WriteLine("Mul is: " + m);
            float n = (float)i / j;
            Console.WriteLine("Div is: " + n);
            int o = i % j;
            Console.WriteLine("Pcn is: " + o);

        }
    }
}
