using System;

namespace Lesson10_练习题
{
    class Program
    {
        static int Compare(int a,int b)
        {
            return a > b ? a : b;
        }

        #region 练习题一
        static float Compare(float f1,float f2)
        {
            return f1 > f2 ? f1 : f2;
        }

        static double Compare(double d1,double d2)
        {
            return d1 > d2 ? d1 : d2;
        }
        #endregion

        #region 练习题二
        static int Compare(params int[] arr)
        {
            if(arr.Length == 0)
            {
                Console.WriteLine("没有传入任何参数");
                return -1;
            }
            int max = arr[0];
            for(int i = 0;i < arr.Length;i++)
            {
                max = arr[i];
            }
            return max;
        }

        static float Compare(params float[] arr)
        {
            if (arr.Length == 0)
            {
                Console.WriteLine("没有传入任何参数");
                return -1;
            }
            float max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                max = arr[i];
            }
            return max;
        }

        static double Compare(params double[] arr)
        {
            if (arr.Length == 0)
            {
                Console.WriteLine("没有传入任何参数");
                return -1;
            }
            double max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                max = arr[i];
            }
            return max;
        }
        #endregion
        static void Main(string[] args)
        {
            Console.WriteLine("函数重载练习题");
            Console.WriteLine("练习题1");
            Console.WriteLine(Compare(1,2));
            Console.WriteLine(Compare(1.1f, 1.2f));
            Console.WriteLine(Compare(1.5, 2.5));

            Console.WriteLine();
            Console.WriteLine("练习题2");
            Console.WriteLine(Compare(1, 2, 3, 4, 5, 6));
            Console.WriteLine(Compare(1.1f, 1.2f, 1.3f, 1.4f, 1.5f));
            Console.WriteLine(Compare(1.5, 2.5, 3.4, 5.6));
        }
    }
}
