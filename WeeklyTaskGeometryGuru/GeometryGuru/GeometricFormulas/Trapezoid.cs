using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryGuru.GeometricFormulas
{
    internal class Trapezoid
    {
        public void TrapezoidSumPer() 
        {
            Console.WriteLine("______Perimeter Sum_______");
            Console.WriteLine("==========================");
            Console.Write("Enter side A: ");
            int numA = int.Parse(Console.ReadLine());
            Console.Write("Enter side B: ");
            int numB = int.Parse(Console.ReadLine());
            Console.Write("Enter side C: ");
            int numC = int.Parse(Console.ReadLine());
            Console.Write("Enter side D: ");
            int numD = int.Parse(Console.ReadLine());
            Console.WriteLine($"{numA}*{numB} + {numB}*{numC} + {numC}*{numD} + {numD}*{numA} = {numA*numB+numB*numC+numC*numD+numD*numA} ");
            Console.WriteLine("==========================");
        }

        public void TrapezoidSumArea() 
        {
            Console.WriteLine("_________Area Sum_________");
            Console.WriteLine("==========================");
            Console.Write("Enter side A: ");
            int numA = int.Parse(Console.ReadLine());
            Console.Write("Enter side B: ");
            int numB = int.Parse(Console.ReadLine());
            Console.Write("Enter side H: ");
            int numH = int.Parse(Console.ReadLine());
            Console.WriteLine($"{numA} + {numB} / 2 * {numH} = {((numA+numB)/2)*numH}");
            Console.WriteLine("==========================");
        }
    }
}
