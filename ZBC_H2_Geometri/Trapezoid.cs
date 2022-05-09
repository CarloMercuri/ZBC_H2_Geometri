using System;
using System.Collections.Generic;
using System.Text;

namespace ZBC_H2_Geometri
{
    public class Trapezoid : Square
    {
        private double a;

        public double A
        {
            get { return a; }
            set { a = value; }
        }

        private double b;

        public double B
        {
            get { return b; }
            set { b = value; }
        }

        private double c;

        public double C
        {
            get { return c; }
            set { c = value; }
        }

        private double d;

        public double D
        {
            get { return D; }
            set { D = value; }
        }

        private double height;

        public Trapezoid(double a, double b, double c, double d, string name) : base(name)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;

            FindHeight();
        }

        public override string GetMeasurements()
        {
            return $"Measurements - a: {this.a}, b: {this.b}, c: {this.c}, d: {this.d}";
        }

        public override double CalculatePerimeter()
        {
            return a + b + c + d;
        }

        private void FindHeight()
        {
            double s = (a + b - c + d) / 2;

            double stepa = 2 / (a - c);
            Console.WriteLine();
            double content = s * (s - a + c) * (s - b) * (s - d);
            Console.WriteLine();
            double sqr = Math.Sqrt(content);
            Console.WriteLine();

            height = (2 / (a - c)) * Math.Sqrt(s * (s - a + c) * (s - b) * (s - d));
        }

        public override double CalculateArea()
        {
            return ((a + c) * height) / 2;
        }
    }     

}
