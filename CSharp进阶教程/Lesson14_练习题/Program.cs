using System;

namespace Lesson14_练习题
{
    #region 练习题
    //写一个函数传入一个整数，返回一个函数
    //之后执行这个匿名函数时传入一个整数和之前那个函数传入的数相乘
    //返回结果
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("匿名函数练习题");
            Action<int> a = TestFun(1);
            a(2);
            TestFun(3)(2);
        }
        static Action<int> TestFun(int a)
        {
            return delegate (int b)
            {
                int c = a * b;
                Console.WriteLine("{0} × {1} = {2}", a, b, c);
            };
        }

        static Func<int,int> TestFun1(int i)
        {
            //这种写法会改变 i的生命周期
            return delegate (int v)
            {
                return i * v;
            };
        }
    }
}
