using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryGuru.GeometricFormulas
{
    internal class Parallelogram
    {
        public void ParallelogramSumPer() 
        {
            Console.WriteLine("______Perimeter Sum_______");
            Console.WriteLine("==========================");
            Console.Write("Enter side A: ");
            int numA = int.Parse(Console.ReadLine());
            Console.Write("Enter side B: ");
            int numB = int.Parse(Console.ReadLine());
            Console.WriteLine($"2 * {numA} + 2 * {numB} = {2*numA+2*numB}");
            Console.WriteLine("==========================");
        }

        public void ParallelogramSumArea() 
        {
            Console.WriteLine("_________Area Sum_________");
            Console.WriteLine("==========================");
            Console.Write("Enter side B: ");
            int numB = int.Parse(Console.ReadLine());
            Console.Write("Enter side H: ");
            int numH = int.Parse(Console.ReadLine());
            Console.WriteLine($"{numB} * {numH} = {numB * numH}");
            Console.WriteLine("==========================");
        }
    }
}
