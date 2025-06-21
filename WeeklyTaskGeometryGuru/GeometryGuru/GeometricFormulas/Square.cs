using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryGuru.GeometricFormulas
{
    internal class Square
    {
        public void SquareSumPer() 
        {
            Console.WriteLine("______Perimeter Sum_______");
            Console.WriteLine("==========================");
            Console.Write("Enter side A: ");
            int numA = int.Parse(Console.ReadLine());
            Console.WriteLine($"Perimeter: 4 * {numA} = {4 * numA}");
            Console.WriteLine("==========================");
        }

        public void SquareSumArea() 
        {
            Console.WriteLine("_________Area Sum_________");
            Console.WriteLine("==========================");
            Console.Write("Enter side A: ");
            int numA = int.Parse(Console.ReadLine());
            Console.WriteLine($"Area: {numA} * {numA} = {numA * numA}");
            Console.WriteLine("==========================");
        }
    }
}
