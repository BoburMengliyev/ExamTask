using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryGuru.GeometricFormulas
{
    internal class Rectangle
    {
        public void RectangleSumPer() 
        {
            Console.WriteLine("______Perimeter Sum_______");
            Console.WriteLine("==========================");
            Console.Write("Enter side A: ");
            int numA = int.Parse(Console.ReadLine());
            Console.Write("Enter side B: ");
            int numB = int.Parse(Console.ReadLine());

            Console.WriteLine($"Perimeter: 2*{numA} + 2*{numB} = {2 * numA + 2 * numB}");
            Console.WriteLine("==========================");
        }

        public void RectangleSumArea() 
        {
            Console.WriteLine("_________Area Sum_________");
            Console.WriteLine("==========================");
            Console.Write("Enter side A: ");
            int numA = int.Parse(Console.ReadLine());
            Console.Write("Enter side B: ");
            int numB = int.Parse(Console.ReadLine());

            Console.WriteLine($"Area: {numA} * {numB} = {numA * numB}");
            Console.WriteLine("==========================");
        }
    }
}