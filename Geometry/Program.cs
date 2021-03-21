﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();
            Point p2 = new Point();
            Point p3 = new Point();
            Point p4 = new Point();

            Console.WriteLine($"$p1 = {p1}");
            Console.WriteLine($"p2 = {p2}");


            Console.WriteLine($"Distanta de la punctul {p3} la origine este {p3.DistanceToOrigin()}");


            Console.WriteLine($"Distanta de la punctul {p3} la {p2} este {p3.DistanceTo(p2).ToString("#.##")}");


            p1.MoveBy(-3.0, 4.0);

            Console.WriteLine($"p1 = {p1}");




            Line line1 = new Line(p2, p3);

            Line line2 = new Line(1.0, 2.0, 3.0, 4.0);

            Console.WriteLine($"line1 = {line1}, length = {line1.Length}");
        }
    }
}
