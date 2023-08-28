using Herança_e_Polimorfismo_10.Entities;
using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using Herança_e_Polimorfismo_10.Entities.Enums;

namespace Seção_10 {
    class Program {
        private static double heigth;

        static void Main(string[] args) {

            List<Shape> list = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {

                Console.WriteLine($"Shape #{i} data:");

                Console.Write("Rectangle or Cicle (r/c)? ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if(ch == 'r') {

                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Heigth: ");
                    double height = double.Parse(Console.ReadLine() , CultureInfo.InvariantCulture);

                    list.Add(new Rectangle(width, heigth, color));

                }

                else {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circle(radius, color));
                }

                Console.WriteLine();

                Console.WriteLine("SHAPE AREAS: ");
                foreach (Shape shape in list) {

                    Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
                }

            }

        }
    }
}
