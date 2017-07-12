using FlyweightPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern.Classes
{
    public class Circle : IShape
    {
        private string color;
        private int x;
        private int y;
        private int radius;

        public Circle(string color)
        {
            this.color = color;
        }

        public void SetX(int x)
        {
            this.x = x;
        }

        public void SetY(int y)
        {
            this.y = y;
        }

        public void SetRadius(int radius)
        {
            this.radius = radius;
        }

        public void Draw()
        {
            Console.WriteLine(String.Format("Circle: Draw() [Color: {0}, x: {1}, y: {2}, radius: {3}", color, x, y, radius));
        }
    }
}
