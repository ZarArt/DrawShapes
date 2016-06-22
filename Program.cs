using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawShapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите высоту фигуры: ");
            int height = Int32.Parse(Console.ReadLine());

            DrawSquare(height);
            Console.ReadLine();
        }

        private static void DrawSquare(int height)
        {
            for (int i = 1; i <= height; i++)
            {
                for (int j = 1; j <= height; j++)
                {
                    if (i == 1 || i == height)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        if (j == 1 || j == height)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
                Console.Write("\n");
            }
        }
    }
}
