using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryGuru.Selection
{
    internal class SelectionOne
    {
        public void MainMenu() 
        {
            while (true) 
            {
                Console.WriteLine("___Welcome GeometryGuru___");
                Console.WriteLine("==========================");
                Console.WriteLine("[1] Rectangle");
                Console.WriteLine("[2] Square");
                Console.WriteLine("[3] RightTriangle");
                Console.WriteLine("[4] Trapezoid");
                Console.WriteLine("[5] Parallelogram");
                Console.WriteLine("[0] Exit");
                Console.WriteLine("==========================");
                Console.Write("Choose: ");

                int choose = 0;
                choose = int.Parse(Console.ReadLine());
                string shapeType = "";

                switch (choose)
                {
                    case 1:
                        Console.WriteLine("________Rectangle_________");
                        Console.WriteLine("==========================");
                        shapeType = "Rectangle";
                        break;
                    case 2:
                        Console.WriteLine("________Square_________");
                        Console.WriteLine("==========================");
                        shapeType = "Square";
                        break;
                     case 3: 
                        Console.WriteLine("___RightTriangle___");
                        Console.WriteLine("==========================");
                        shapeType = "RightTriangle";
                        break;
                      case 4:
                        Console.WriteLine("___Trapezoid___");
                        Console.WriteLine("==========================");
                        shapeType = "Trapezoid";
                        break;
                        case 5:
                        Console.WriteLine("___Parallelogram___");
                        Console.WriteLine("==========================");
                        shapeType = "Parallelogram";
                        break;
                    case 0:
                        Console.WriteLine("The program has been closed.");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        System.Threading.Thread.Sleep(1000);
                        Console.Clear();
                        continue;
                }
                Console.Clear();
                SubMenu subMenu = new SubMenu();
                subMenu.SubMenuSelection(shapeType);
                Console.Clear();
            }
        }
    }
}