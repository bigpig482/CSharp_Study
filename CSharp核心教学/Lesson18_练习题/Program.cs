using System;

namespace Lesson18_练习题
{
    #region 练习题1
    //写一个动物抽象类，写三个子类人叫，狗叫，猫叫
    abstract class Animal
    {
        public abstract void Call();
    }

    class Person : Animal
    {
        public override void Call()
        {
            Console.WriteLine("人叫");
        }
    }

    class Dog : Animal
    {
        public override void Call()
        {
            Console.WriteLine("汪汪汪");
        }
    }

    class Cat : Animal
    {
        public override void Call()
        {
            Console.WriteLine("喵喵喵");
        }
    }
    #endregion

    #region 练习题2
    //创建一个图形类，有求面积和周长两个方法
    //创建矩形类，正方形类，圆形类继承图形类
    //实例化矩形、正方形、圆形对象求面积和周长
    abstract class Graphics
    {
        public abstract void GetArea();
        public abstract void GetLength();
    }

    class Rectangle : Graphics
    {
        public int w;
        public int h;
        public Rectangle(int w,int h)
        {
            this.w = w;
            this.h = h;
        }
        public override void GetArea()
        {
            int area = w * h;
            Console.WriteLine("矩形的面积为{0}",area);
        }

        public override void GetLength()
        {
            int length = 2 * (w + h);
            Console.WriteLine("矩形的周长为{0}",length);
        }
    }

    class Squara : Graphics
    {
        public int l;
        public Squara(int l)
        {
            this.l = l;
        }

        public override void GetArea()
        {
            int area = l * l;
            Console.WriteLine("正方形的面积为{0}", area);
        }

        public override void GetLength()
        {
            int length = 4 * l;
            Console.WriteLine("正方形的周长为{0}", length);
        }
    }

    class Circle : Graphics
    {
        public int r;
        public static float PI = 3.14f;
        public Circle(int r)
        {
            this.r = r;
        }
        public override void GetArea()
        {
            float area = r * PI * r;
            Console.WriteLine("圆形的面积为{0}", area);
        }

        public override void GetLength()
        {
            float length = 2 * PI * r;
            Console.WriteLine("圆形的周长为{0}", length);
        }
    }

    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("抽象类和抽象方法练习题");
            Animal p = new Person();
            Animal dog = new Dog();
            Animal cat = new Cat();
            p.Call();
            dog.Call();
            cat.Call();

            Graphics re = new Rectangle(4,5);
            Graphics sq = new Squara(3);
            Graphics ci = new Circle(6);
            re.GetArea();
            re.GetLength();
            sq.GetArea();
            sq.GetLength();
            ci.GetArea();
            ci.GetLength();
        }
    }
}