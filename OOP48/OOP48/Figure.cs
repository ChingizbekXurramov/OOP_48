using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP48
{
    abstract class Figure
    {
        public abstract double Ploshad();
        public abstract double Perimetr();
    }
    class Krug : Figure
    {
        private double _radius;

        public double Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }

        public Krug(double radius)
        {
            Radius = radius;
        }

        public override double Ploshad()
        {
            return Math.PI * Radius * Radius;
        }

        public override double Perimetr()
        {
            return 2 * Math.PI * Radius;
        }
    }

    class Triugolnik : Figure
    {
        private double _side1;
        private double _side2;
        private double _side3;

        public double Side1
        {
            get { return _side1; }
            set { _side1 = value; }
        }

        public double Side2
        {
            get { return _side2; }
            set { _side2 = value; }
        }

        public double Side3
        {
            get { return _side3; }
            set { _side3 = value; }
        }

        public Triugolnik(double side1, double side2, double side3)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;

            PravilnoZaputanniyTriugolnik();
        }

        private void PravilnoZaputanniyTriugolnik()
        {
            double[] sides = new double[] { Side1, Side2, Side3 };
            Array.Sort(sides);

            if (Math.Pow(sides[2], 2) == Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nTriugolnik predsyavlyayet soboy pryamougolniy triugolnik\n");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nTriugolnik ne predstavlyayet soboy pryamougolniy triugolnik\n");
            }
        }

        public override double Ploshad()
        {
            double s = (Side1 + Side2 + Side3) / 2;
            return Math.Sqrt(s * (s - Side1) * (s - Side2) * (s - Side3));
        }

        public override double Perimetr()
        {
            return Side1 + Side2 + Side3;
        }
    }
}

