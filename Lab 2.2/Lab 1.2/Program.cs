using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Rectangle
    {
        double side1, side2, area, perimeter;

        private double Side1
        {
            get { return side1; }
            set { Side1 = value; }
        }

        private double Side2
        {
            get { return side2; }
            set { Side2 = value; }
        }

        private double Area
        {
            get { return area; }
        }

        private double Perimeter
        {
            get { return perimeter; }
        }

        public void GetInfo()
        {
            Console.WriteLine($"Площа = {Area}, Периметер = {Perimeter}");
        }


        class Program
        {
            static double AreaCalculator(double side12, double side21)
            {
                double ar = side12 * side21;
                return ar;
            }
            static double PerimeterCalculator(double side12, double side21)
            {
                double pe = (side12 + side21) * 2;
                return pe;
            }


            static void Main(string[] args)
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                Rectangle a = new Rectangle();
                Console.Write("Введіть сторону №1 прямокутника");
                a.side1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введіть сторону №2 прямокутника");
                a.side2 = Convert.ToDouble(Console.ReadLine());
                a.area = AreaCalculator(a.side1, a.side2);
                a.perimeter = PerimeterCalculator(a.side1, a.side2);
                a.GetInfo();
                Console.ReadKey();



            }
        }

    }
}
