using FlyweightPattern.Classes;
using FlyweightPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern.Factories
{
    public class ShapeFactory
    {
        private static readonly Dictionary<string, IShape> circleMap = new Dictionary<string, IShape>();

        public static IShape getCircle(string color)
        {
            Circle circle = new Circle(color);
            if(circleMap.Keys.Contains(color))
            {
                circle = (Circle)circleMap[color];
            }
            else
            {
                circleMap.Add(color, circle);
                Console.WriteLine(String.Format("Creating circle of color : {0}", color));
            }
            return circle;
        }
    }
}
