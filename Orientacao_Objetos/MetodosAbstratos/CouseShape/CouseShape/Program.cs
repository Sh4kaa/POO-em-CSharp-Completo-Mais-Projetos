using CouseShape.Entities;
using CouseShape.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace CouseShape
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} data: ");
                Console.Write("Rectangle or Circle (r/c)? ");
                char sh = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color color; Enum.TryParse(Console.ReadLine(), out color);

                if(sh == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Rectangle (width, height, color));
                }
                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circle(color, radius));
                }
                
               
            }

            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS:");

            foreach (Shape ssh in list)
            {
                Console.WriteLine(ssh.Area().ToString("f2", CultureInfo.InvariantCulture));
            }
        }
    }
        
      
}
