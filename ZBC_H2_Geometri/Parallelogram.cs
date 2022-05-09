using System;
using System.Collections.Generic;
using System.Text;

namespace ZBC_H2_Geometri
{
    public class Parallelogram : Square
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

        private double angle;

        public double Angle
        {
            get { return angle; }
            set { angle = value; }
        }


        public Parallelogram(float width, float height, double angle, string name) : base(name)
        {
            this.width = width;
            this.height = height;
            this.angle = angle;
        }

        public override string GetMeasurements()
        {
            return $"Measurements - Width: {this.width}, Height: {this.height}, Angle: {this.Angle}";
        }

        public override double CalculateArea()
        {
            return width * height * Math.Sin(angle);
        }

        public override double CalculatePerimeter()
        {
            return width * 2 + height * 2;
        }
    }
}
