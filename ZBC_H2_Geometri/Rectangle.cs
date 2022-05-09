using System;
using System.Collections.Generic;
using System.Text;

namespace ZBC_H2_Geometri
{
    public class Rectangle : Square
    {
        private double width;

        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        private double height;

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public Rectangle(double width, double height, string name) : base(name)
        {
            this.width = width;
            this.height = height;
        }

        public override string GetMeasurements()
        {
            return $"Measurements - Width: {this.width}, Height: {this.height}";
        }

        public override double CalculateArea()
        {
            return width * height;
        }

        public override double CalculatePerimeter()
        {
            return width * 2 + height * 2;
        }
    }
}
