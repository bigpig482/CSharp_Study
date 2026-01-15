using System;

namespace Lesson10_封装_运算符重载
{
    #region 知识点一 基本概念
    //概念
    //让自定义类和结构体
    //能够使用运算符

    //使用关键字
    //operator

    //特点
    //1.一定是一个公共的静态方法
    //2.返回值写在operator前
    //3.逻辑处理自定义

    //作用
    //让自定义类和结构体对象可以进行运算
    //注意
    //1.条件运算符需要成对实现
    //2.一个符号可以多个重载
    //3.不能使用ref和out

    #endregion

    #region 知识点二 基本语法
    //public stataic 返回类型 operator 运算符(参数列表)
    #endregion

    #region 知识点三 实例
    class Point
    {
        public int x;
        public int y;

        public static Point operator +(Point p1,Point p2)
        {
            Point p = new Point();
            p.x = p1.x + p2.x;
            p.y = p1.y + p2.y;
            return p;
        }

        //可以重载
        //Point + int
        public static Point operator +(Point p1,int value)
        {
            Point p = new Point();
            p.x = p1.x + value;
            p.y = p1.y + value;
            return p;
        }

        //int + Point
        public static Point operator +(int value, Point p1)
        {
            Point p = new Point();
            p.x = p1.x + value;
            p.y = p1.y + value;
            return p;
        }
    }
    #endregion

    #region 知识点五 可重载和不可重载运算符

    #region 可重载运算符

    #region 算数运算符
    //注意:符号需要两个参数还是一个参数
    // + - * % /  ++ --
    #endregion

    #region 逻辑运算符
    //注意:符号需要两个参数还是一个参数
    //！
    #endregion

    #region 位运算符
    //注意:符号需要两个参数还是一个参数
    //位与&  位或| 异或^ 位取反~ 左移<< 右移>>
    #endregion

    #region 条件运算符
    //1.返回值一般是bool值 也是可以是其他的
    //2.相关符号必须配对实现
    //== != >= <=
    #endregion

    #endregion

    #region 不可重载运算符
    //逻辑与(&&) 逻辑或(||)
    //索引符[]
    //强转运算符()
    //特殊运算符
    //点 .  三目运算符 ? : 赋值符号=
    #endregion

    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("运算符重载");
            #region 知识点四 使用
            Point p = new Point();
            p.x = 1;
            p.y = 2;
            Point p2 = new Point();
            p2.x = 3;
            p2.y = 4;

            Point p3 = p + p2;
            Point p4 = p3 + 2;
            Point p5 = 2 + p3;

            #endregion
        }
    }
    //总结
    //关键
    //operator
    //固定语法:
    //public static 返回值 operator 运算符(参数列表)
    //作用:
    //让子弟定义类或结构体对象 进行计算
    //注意:
    //1.参数的数量
    //2.条件运算符的配对实现
    //3.一个符号可以多个重载
    //4.不能用ref和out
}
