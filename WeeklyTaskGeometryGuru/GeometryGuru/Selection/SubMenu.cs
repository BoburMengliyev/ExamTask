using GeometryGuru.GeometricFormulas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryGuru.Selection
{
    internal class SubMenu
    {
        public void SubMenuSelection(string shapeType) 
        {
            Console.Clear();
            while (true) 
            {
                Console.WriteLine("___Welcome GeometryGuru___");
                Console.WriteLine("==========================");
                Console.WriteLine("[1] Perimeter");
                Console.WriteLine("[2] Area");
                Console.WriteLine("[0] Exit");
                Console.WriteLine("==========================");
                Console.Write("Choose: ");

                int choose = 0;
                choose = int.Parse(Console.ReadLine());
                Rectangle rectangle = new Rectangle();
                Square square = new Square();
                RightTriangle triangle = new RightTriangle();
                Trapezoid trapezoid = new Trapezoid();
                Parallelogram parallelogram = new Parallelogram();

                switch (choose) 
                {
                    case 1:
                        if (shapeType == "Rectangle")
                        {
                            rectangle.RectangleSumPer();
                        }
                        else if (shapeType == "Square")
                        {
                            square.SquareSumPer();
                        }
                        else if (shapeType == "RightTriangle")
                        {
                            triangle.RightTriangleSumPer();
                        }
                        else if (shapeType == "Trapezoid")
                        {
                            trapezoid.TrapezoidSumPer();
                        }
                        else if (shapeType == "Parallelogram") 
                        {
                            parallelogram.ParallelogramSumPer();
                        }
                            Console.ReadLine();
                        break;

                    case 2:
                        if (shapeType == "Rectangle")
                        {
                            rectangle.RectangleSumArea();
                        }
                        else if (shapeType == "Square")
                        {
                            square.SquareSumArea();
                        }
                        else if (shapeType == "RightTriangle")
                        {
                            triangle.RightTriangleSumArea();
                        }
                        else if (shapeType == "Trapezoid")
                        {
                            trapezoid.TrapezoidSumArea();
                        }
                        else if (shapeType == "Parallelogram") 
                        {
                            parallelogram.ParallelogramSumArea();
                        }
                            Console.ReadLine();
                        break;

                    case 0: 
                        Console.WriteLine("Returned to the main menu.");
                        System.Threading.Thread.Sleep(1000);
                        return;

                    default: 
                        Console.WriteLine("Invalid choice. Please try again.");
                        System.Threading.Thread.Sleep(1000);
                        break;
                }
                Console.Clear();
            }
        }
    }
}