using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Person A = new Person(12, "Luna");
            Console.WriteLine(A);

            Person b = new Person(20, "Carter");
            Console.WriteLine(b);
        }
    }
}
