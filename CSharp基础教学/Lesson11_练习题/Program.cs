using System;

namespace Lesson11_练习题
{
    class Program
    {
        #region 练习题1
        //使用递归的方式打印0~10
        static void Fun(int a)
        {
            if (a > 10)
            {
                return;
            }
            Console.WriteLine(a);
            a++;
            Fun(a);
        }
        #endregion

        //111
        #region 练习题2
        //传入一个值，递归求该值的阶乘并返回 5！= 1*2*3*4*5
        static int Factorial(int num)
        {
            if(num == 1)
            {
                return 1;
            }
            return num * Factorial(num - 1);
        }
        #endregion

        //111
        #region 练习题3
        //使用递归求1！+2！+3！+4！+......+10!
        static int Factorial2(int num = 10)
        {
            if(num == 1)
            {
                return Factorial(1);
            }
            return Factorial(num) + Factorial2(num - 1);
        }
        #endregion

        #region 练习题4
        //一根竹竿长100m，每天砍掉一半，求第十天它的长度是多少(从第0天开始)
        static float Fun4(float a = 100f,int b = 0)
        {
            
            a /= 2f;
            if (b == 10)
            {
                return a;
            }
            
            b++;
            return Fun4(a, b);
        }

        #endregion

        //111
        #region 练习题5
        //不允许使用循环语句、条件语句，在控制台中打印出1~200这200个数（提示：递归+短路）
        static bool Fun5(int a = 1)
        {
            Console.WriteLine(a);
            return a == 200 || Fun5(a + 1);
        }
        #endregion

        static void Main(string[] args)
        {
            Console.WriteLine("递归函数练习题");
            Console.WriteLine("练习题1");
            Fun(1);

            Console.WriteLine();
            Console.WriteLine("练习题2");
            Console.WriteLine(Factorial(5));

            Console.WriteLine();
            Console.WriteLine("练习题3");
            Console.WriteLine(Factorial2());

            Console.WriteLine();
            Console.WriteLine("练习题4");
            Console.WriteLine(Fun4());

            Console.WriteLine();
            Console.WriteLine("练习题5");
            Fun5();
        }
    }
}
