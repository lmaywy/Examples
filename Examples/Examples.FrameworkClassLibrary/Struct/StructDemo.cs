using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.FrameworkClassLibrary.Struct
{
    public class StructDemo
    {
        public static void Demo()
        {
            var pointA = new Point(10, 20);
            pointA.Draw();

            Point pointB;
            pointB.x = 25;
            pointB.y = 20;
            //pointB.Color = new Color { Name = "Blue" };
            //pointB.Draw();
            Console.WriteLine("x:{0},y:{1}", pointB.x, pointB.y);
        }
    }
}
