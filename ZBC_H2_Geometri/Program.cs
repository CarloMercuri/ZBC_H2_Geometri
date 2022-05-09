using System;
using System.Collections.Generic;

namespace ZBC_H2_Geometri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Square> objectsList = new List<Square>();

            objectsList.Add(new Square(10, "Square"));
            objectsList.Add(new Rectangle(10, 5, "Rectangle"));
            objectsList.Add(new Parallelogram(10, 5, 70, "Parallelogram"));
            objectsList.Add(new Trapezoid(10, 6, 8, 5, "Trapezoid"));
            objectsList.Add(new RightAngledTriangle(10, 15, "RightAngledTriangle"));

            for (int i = 0; i < objectsList.Count; i++)
            {
                Console.WriteLine($"Shape: {objectsList[i].GetName()}");
                Console.WriteLine($"Measurements: {objectsList[i].GetMeasurements()}");
                Console.WriteLine($"Area: {objectsList[i].CalculateArea()}");
                Console.WriteLine($"Perimeter: {objectsList[i].CalculatePerimeter()}");
                Console.WriteLine();
                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}
