using System;

namespace Lesson5_练习题
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("值类型和引用类型练习题");

            #region 练习题一
            //int a = 10;
            //int b = a;
            //b = 20;
            //Console.WriteLine(a);
            //请问打印结果为多少
            //打印结果为10
            #endregion

            #region 练习题二
            int[] a = new int[] { 10 };
            int[] b = a;
            b[0] = 20;
            Console.WriteLine(a[0]);
            //请问打印结果为多少
            //打印结果为20
            #endregion

            #region 练习题三
            string str = "123";
            string str2 = str;
            str2 = "321";
            Console.WriteLine(str);
            //请问打印结果为多少
            //打印结果为123
            //string类型是一个特殊的引用类型 它不遵循 它变我也变的规律
            #endregion
        }
    }
}
