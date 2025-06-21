using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryGuru.GeometricFormulas
{
    internal class RightTriangle
    {
        public void RightTriangleSumPer() 
        {
            Console.WriteLine("______Perimeter Sum_______");
            Console.WriteLine("==========================");
            Console.Write("Enter side A: ");
            int numA = int.Parse(Console.ReadLine());
            Console.Write("Enter side B: ");
            int numB = int.Parse(Console.ReadLine());
            Console.Write("Enter side C: ");
            int numC = int.Parse(Console.ReadLine());
            Console.WriteLine($"Perimeter: {numA} + {numB} + {numC} = {numA+numB+numC}");
            Console.WriteLine("==========================");
        }
        public void RightTriangleSumArea() 
        {
            const double x = 0.5;
            Console.WriteLine("_________Area Sum_________");
            Console.WriteLine("==========================");
            Console.Write("Enter side A: ");
            int numA = int.Parse(Console.ReadLine());
            Console.Write("Enter side B: ");
            int numB = int.Parse(Console.ReadLine());
            double natija = x * (numA * numB);
            Console.WriteLine($"Area: 1 / 2 * {numA} * {numB} = {natija}");
            Console.WriteLine("==========================");
        }
    }
}
