using System;

namespace Lesson17_练习题
{
    #region 练习题1
    //真的鸭子嘎嘎叫，木头鸭子吱吱叫，橡皮鸭子唧唧叫
    class Duck
    {
        public virtual void Speak()
        {
            Console.WriteLine("嘎嘎嘎");
        }
    }

    class WoodDuck : Duck
    {
        public override void Speak()
        {
            Console.WriteLine("吱吱吱");
        }
    }

    class EraserDuck : Duck
    {
        public override void Speak()
        {
            Console.WriteLine("唧唧唧");
        }
    }
    #endregion

    #region 练习题2
    //所有员工9点打卡
    //但经理十一点打卡，程序员不打卡
    class Person
    {
        public virtual void PunchIn()
        {
            Console.WriteLine("员工9点打卡");
        }
    }

    class Manager : Person
    {
        public override void PunchIn()
        {
            //base.PunchIn();
            Console.WriteLine("经理11点打卡");
        }
    }

    class Programmer : Manager
    {
        public override void PunchIn()
        {
            //base.PunchIn();
            Console.WriteLine("程序员不打卡");
        }
    }
    #endregion

    #region 练习题3
    //创建一个图形类，有求面积和周长两个方法
    //创建矩形类，正方形类，圆形类继承图形类
    //实例化矩形、正方形、圆形对象求面积和周长
    class Graphics
    {
        public virtual float GetArea(params float[] f)
        {
            return f[0] * f[1];
        }

        public virtual float GetPerimeter(params float[] f)
        {
            return (f[0] + f[1]) * 2;
        }
    }

    class Rectangle : Graphics
    {
        public override float GetArea(params float[] f)
        {
            return 0;
        }

        public override float GetPerimeter(params float[] f)
        {
            return 0;
        }
    }

    class Square : Graphics
    {
        public override float GetArea(params float[] f)
        {
            return f[0] * f[0];
        }
        public override float GetPerimeter(params float[] f)
        {
            return f[0] * 4;
        }
    }

    class Circle : Graphics
    {
        public static float PI = 3.14f;

        public override float GetArea(params float[] f)
        {
            return PI * f[0] * f[0];
        }
        public override float GetPerimeter(params float[] f)
        {
            return f[0] * 2 * PI;
        }
    }
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vob练习题");
            #region 练习题1

            Duck duck = new Duck();
            Duck mduck = new WoodDuck();
            Duck educk = new EraserDuck();
            duck.Speak();
            mduck.Speak(); 
            educk.Speak();

            #endregion

            #region 练习题2
            Person p = new Person();
            Person m = new Manager();
            Person pr = new Programmer();
            p.PunchIn();
            m.PunchIn();
            pr.PunchIn();
            #endregion

            #region 练习题3
            Graphics re = new Rectangle();
            Graphics sq = new Square();
            Graphics ci = new Circle();
            Console.WriteLine("矩形的面积为{0}周长为{1}", re.GetArea(4, 5), re.GetPerimeter(4, 5));
            Console.WriteLine("正方形面积为{0}周长为{1}", sq.GetArea(3), sq.GetPerimeter(3));
            Console.WriteLine("圆面积为{0}周长为{1}", ci.GetArea(6), ci.GetPerimeter(6));
            #endregion
        }
    }
}
