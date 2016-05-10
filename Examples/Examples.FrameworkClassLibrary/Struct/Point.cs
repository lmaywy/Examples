using System;

namespace Examples.FrameworkClassLibrary.Struct
{
    /// <summary>
    /// 一个结构不能从另一个结构或类继承，而且不能作为一个类的基。所有结构都直接继承自 System.ValueType，后者继承自 System.Object。
    /// 结构还可以包含构造函数、常量、字段、方法、属性、索引器、运算符、事件和嵌套类型，但如果同时需要上述几种成员，则应当考虑改为使用类作为类型。
    /// 结构可以实现接口
    /// </summary>
    public struct Point : IPoint
    {
        public int x, y;

        private const int z = 20;

        public Color Color2 { get { return new Color { Name = "Red" }; } }

        //public int z = 10; 除非字段被声明为 const 或 static，否则无法初始化。

        public Point(int p1, int p2)
        {
            x = p1;
            y = p2;
        }

        public void Draw()
        {
            Console.WriteLine("x:{0},y:{1},the color of point:{2}", x, y, Color2.Name);
        }

        //结构不能声明默认构造函数（没有参数的构造函数）或析构函数。
        //public Point()
        //{

        //}
    }

    interface IPoint
    {
        void Draw();
    }

    public class Color
    {
        public string Name { get; set; }
    }
}
