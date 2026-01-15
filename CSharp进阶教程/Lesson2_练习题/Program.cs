using System;
using System.Collections;

namespace Lesson2_练习题
{
    #region 练习题1
    //请简述栈的存储规则

    //先进后出
    #endregion

    #region 练习题2
    //写一个方法计算任意一个数的二进制数
    //使用栈结构方式存储，之后打印出来
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stack练习题");
            Binary(10);
        }

        static void Binary(uint a)
        {
            Console.Write("{0}的二进制是:",a);
            Stack stack = new Stack();
            while (true)
            {
                stack.Push(a % 2);
                a /= 2;
                if (a == 1)
                {
                    stack.Push(a);
                    break;
                }
            }

            //循环弹栈
            while(stack.Count > 0)
            {
                Console.Write(stack.Pop());
            }
            Console.WriteLine();
        }

        //public static int Fun(int i)
        //{
        //    Stack stack = new Stack();
        //    int num = 0;
        //    if (i / 2 == 1)
        //    {
        //        return 1;
        //    }
        //    i = i / 2;
        //    num = i;
        //    stack.Push(num);
        //    return Fun(i / 2);
        //}
    }
}
