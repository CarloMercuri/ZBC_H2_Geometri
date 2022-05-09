using System;
using System.Collections.Generic;
using System.Text;

namespace ZBC_H2_Geometri
{
    public class Square
    {
        private double sideLenght;

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        public Square(double sideLenght, string name)
        {
            this.sideLenght = sideLenght;
            this.name = name;
        }

        public Square(string name)
        {
            this.name=name;
        }

        public string GetName()
        {
            return name;
        }

        public virtual string GetMeasurements()
        {
            return $"Side lenght: {sideLenght}";
        }

        public virtual double CalculateArea()
        {
            return sideLenght * sideLenght;
        }

        public virtual double CalculatePerimeter()
        {
            return sideLenght * 4;
        }
    }
}
