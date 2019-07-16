using System;

namespace Formulas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Tri(4, 8));
        }



        public static double Rect(double side1, double side2)
        {
            double area = side1 * side2;
            return area;
        }

        public static double Circ(double radius)
        {
            double area = Math.PI * Math.Pow(radius, 2);
            return area;
        }

        public static double Tri(double width, double height)
        {
            double area = (width * height) / 2;
            return area;
        }

        public static double Dist(double x, double y, double x2, double y2)
        {
            double rise = y2 - y;
            double run = x2 - x;
            double distance = Math.Sqrt(Math.Pow(rise, 2) + Math.Pow(run, 2));
            return distance;
        }

        public static string Midpoint(double x, double y, double x2, double y2)
        {
            double midx = x + (x2 - x)/2;
            double midy = y + (y2 - y)/2;
            return "(" + midx + ", " + midy + ")";
        }


    }
}
