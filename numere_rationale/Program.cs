using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numere_rationale
{
    class Program
    {
        static void Main(string[] args)
        {
            Rational r1 = new Rational(12, 5);
            Console.WriteLine(r1);
            Rational r2 = new Rational(-20, -3);
            Console.WriteLine(r2);
            Rational r3 = new Rational(4, 7);

            Rational sum = r1.Add(r2);
            Console.WriteLine($"{r1} + {r2} = {sum}");

            Rational multiply = r1.Multiply(r2);
            Console.WriteLine($"{r1} * {r2} = {multiply}");

            Rational devide = r1.Devide(r2);
            Console.WriteLine($"{r1} / {r2} = {devide}");
        }
       
    }
}
