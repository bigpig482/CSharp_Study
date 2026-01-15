using System;

namespace Lesson8_练习题
{
    #region 练习题
    //写一个用于数学计算的静态类
    //该类中提供计算圆面积,圆周长,矩形面积,矩形周长,取一个数的绝对值等方法
    static class MathTools
    {
        //Π
        public static float PI;

        //静态构造函数
        static MathTools()
        {
            PI = 3.14f;
        }

        //计算圆面积
        public static float AreaCalc(float r)
        {
            return PI * r * r;
        }

        //计算圆周长
        public static float PerimeterCalc(float r)
        {
            return 2 * PI * r;
        }

        //计算矩形面积
        public static float RectangleArea(int l,int h)
        {
            return l * h;
        }

        //计算矩形周长
        public static float RectanglePerimeter(int l,int h)
        {
            return 2 * (l + h);
        }

        //取一个数的绝对值
        public static int AbsoluteValue(int i)
        {
            if(i < 0)
            {
                return i = -i;
            }
            else
            {
                return i;
            }
        }
    }

    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("静态类和静态构造函数练习题");
            Console.WriteLine(MathTools.AreaCalc(3));
            Console.WriteLine(MathTools.PerimeterCalc(3));
            Console.WriteLine(MathTools.RectangleArea(3,4));
            Console.WriteLine(MathTools.RectanglePerimeter(3,4));
            Console.WriteLine(MathTools.AbsoluteValue(-1));
        }
    }
}
