using System;

namespace Lesson10_练习题
{
    #region 练习题1
    //定义一个位置结构体或类,为其重载判断是否相等的运算符
    //(x1,y1) == (x2,y2) => 两个值同时相等才为true
    class Point
    {
        public int x;
        public int y;

        public Point()
        {
            x = 1;
            y = 1;
        }

        public Point(int x,int y)
        {
            this.x = x;
            this.y = y;
        }

        public static bool operator ==(Point p1,Point p2)
        {
            if(p1.x == p2.x && p1.y == p2.y)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Point p1, Point p2)
        {
            if (p1.x == p2.x && p1.y == p2.y)
            {
                return false;
            }
            return true;
        }
    }
    #endregion

    #region 练习题2
    //定义一个Vector3类(x,y,z)通过重载运算符实现以下运算
    //(x1,y1,z1) + (x2,y2,z2) = (x1 + x2,y1 + y2,z1 + z2)
    //(x1,y1,z1) - (x2,y2,z2) = (x1 - x2,y1 - y2,z1 - z2)
    //(x1,y1,z1) * num = (x1 * num,y1 * num,z1 * num)
    class Vector3
    {
        public int x;
        public int y;
        public int z;

        public Vector3()
        {
            x = 1;
            y = 2;
            z = 3;
        }

        public Vector3(int x,int y)
        {
            this.x = x;
            this.y = y;
        }

        public Vector3(int x,int y,int z):this(x,y)
        {
            this.z = z;
        }

        public static Vector3 operator +(Vector3 v1, Vector3 v2)
        {
            Vector3 v3 = new Vector3();
            v3.x = v1.x + v2.x;
            v3.y = v1.y + v2.y;
            v3.z = v1.z + v2.z;
            return v3;
        }

        public static Vector3 operator -(Vector3 v1, Vector3 v2)
        {
            Vector3 v3 = new Vector3();
            v3.x = v1.x - v2.x;
            v3.y = v1.y - v2.y;
            v3.z = v1.z - v2.z;
            return v3;
            //return new Vector3(v1.x - v2.x, v1.y - v2.y, v1.z - v2.z);
        }

        public static Vector3 operator *(Vector3 v1, int num)
        {
            Vector3 v3 = new Vector3();
            v3.x = v1.x * num;
            v3.y = v1.y * num;
            v3.z = v1.z * num;
            return v3;
        }
    }
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("运算符重载练习题");

            #region 练习题1
            Point p1 = new Point();
            Point p2 = new Point(1,1);
            Console.WriteLine(p1 == p2);
            #endregion

            #region 练习题2
            Vector3 v = new Vector3();
            Vector3 v2 = new Vector3(4,5,6);
            Vector3 v3 = v + v2;
            Vector3 v4 = v - v2;
            Vector3 v5 = v * 2;
            Console.WriteLine("x = {0},y = {1}, z = {2}",v3.x,v3.y,v3.z);
            Console.WriteLine("x = {0},y = {1}, z = {2}", v4.x, v4.y, v4.z);
            Console.WriteLine("x = {0},y = {1}, z = {2}", v5.x, v5.y, v5.z);
            #endregion
        }
    }
}