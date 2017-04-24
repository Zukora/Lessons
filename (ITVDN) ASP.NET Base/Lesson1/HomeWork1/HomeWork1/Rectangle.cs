using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    class Rectangle
    {
        private double side1;
        private double side2;
        private double side3;
        public double Side1
        {
            set
            {
                side1 = value;
            }
            get
            {
                return side1;
            }
        }
        public double Side2
        {
            set
            {
                side2 = value;
            }
            get
            {
                return side2;
            }
        }
        public double Side3
        {
            set
            {
                side3 = value;
            }
            get
            {
                return side3;
            }
        }
        public Rectangle(double s1,double s2,double s3)
        {
            side1 = s1;
            side2 = s2;
            side3 = s3;
        }
        public double PerimeterCalculator()
        {
            return Side1 + Side2 + Side3;
        }
        public double Perimeter
        {
            get
            {
                return PerimeterCalculator();
            }
        }
        public double AreaCalculator()
        {
            return Math.Sqrt(Perimeter * (Perimeter - Side1) * (Perimeter - side2) * (Perimeter - Side3));

        }
        public double Areas
        {
            get 
            {
                return AreaCalculator();
            }
            

        }
    }
}
