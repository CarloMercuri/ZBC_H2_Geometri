using System;
using System.Collections.Generic;
using System.Text;

namespace ZBC_H2_Geometri
{
    public class RightAngledTriangle : Square
    {
        private double hypotenuse;

        public double Hypotenuse
        {
            get { return hypotenuse; }
            set { hypotenuse = value; }
        }

        private double cathete;

        public double Cathere
        {
            get { return cathete; }
            set { cathete = value; }
        }

        public RightAngledTriangle(double cathete, double hypotenuse, string name) : base(name)
        {
            this.hypotenuse = hypotenuse;
            this.cathete = cathete;
        }

        public override string GetMeasurements()
        {
            return $"Measurements - Cathethi: {this.cathete}, Hypotenuse: {this.hypotenuse}";
        }

        public override double CalculateArea()
        {
            return cathete * 2 / 2;
        }

        public override double CalculatePerimeter()
        {
            return cathete * 2 + hypotenuse;
        }

    }
}
