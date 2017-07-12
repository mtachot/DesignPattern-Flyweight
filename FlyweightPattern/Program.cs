using FlyweightPattern.Classes;
using FlyweightPattern.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    class Program
    {
        private static readonly String[] colors = { "Red", "Green", "Blue", "White", "Black" };
        private static readonly Random rand = new Random();

        public static void Main(string[] args)
        {
            for (int i = 0; i < 20; i++)
            {
                Circle circle = (Circle)ShapeFactory.getCircle(getRandomColor());
                circle.SetX(getRandomX());
                circle.SetY(getRandomY());
                circle.SetRadius(100);
                circle.Draw();
            }

            Console.ReadLine();
        }

        private static string getRandomColor()
        {
            return colors[(int)rand.Next(0, 4)];
        }

        private static int getRandomX()
        {
            return rand.Next(1, 101);
        }

        private static int getRandomY()
        {
            return rand.Next(1, 101);
        }
    }
}
