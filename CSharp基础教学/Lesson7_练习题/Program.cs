using System;

namespace Lesson7_练习题
{
    class Program
    {
        #region 练习题1
        //写一个函数，比较两个数字的大小，返回最大值
        static int Max(int a,int b)
        {
            //if (a > b)
            //{
            //    return a;
            //}
            //else { return b; }
            return a > b ? a : b;
        }
        #endregion

        #region 练习题2
        //写一个函数，用于计算一个圆的面积和周长，并返回打印
        static float[] AreaZc(float r)
        {
            float pai = 3.14f;
            float area = pai * r * r;
            float zc = 2 * r * pai;
            return new float[] { area, zc };
        }
        #endregion

        #region 练习题3
        //写一个函数，求一个数组的总合、最大值、最小值、平均值
        static int[] SumMaxMinAvg(int[] arr)
        {
            int sum = 0;
            int max = arr[0];
            int min = arr[0];
            int avg = 0;
            for (int i = 0;i < arr.Length;i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
                sum = sum + arr[i];
            }
            avg = sum / arr.Length;
            return new int[] { sum, max, min, avg };
        }
        #endregion

        #region 练习题4
        //写一个函数，判断你传入的参数是不是质数
        static string IsPrimeNum(int i)
        {
            int index = 2;
            while(index < i)
            {
                if(i % index == 0)
                {
                    break;
                }
                index++;
            }
            if (i > 1)
            {
                if (index == i)
                {
                    Console.WriteLine("数字" + i);
                    return "这个数是质数";
                }
                else
                {
                    Console.WriteLine("数字" + i);
                    return "这个数不是质数";
                }
            }
            else
            {
                return "这个数不是质数";
            }
        }

        //第二种写法
        static bool IsPrimeNum2(int a)
        { 
            for(int i = 2;i < a;i++)
            {
                if(a % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        #endregion

        #region 练习题5
        //写一个函数，判断你输入的年份是否是闰年
        //闰年判断条件：
        //年份能被400整除（2000)
        //或者
        //年份能被4整除，但是不能被100整除（2008）
        static string IsLeapYear(int i)
        {
            if(i % 400 == 0 || i % 4 == 0 && i %100 != 0)
            {
                Console.WriteLine("输入的年份为{0}",i);
                return "输入的年份是闰年";
            }
            else
            {
                Console.WriteLine("输入的年份为{0}", i);
                return "输入的年份不是闰年";
            }
        }
        //第二种写法
        static bool IsLeapYear2(int i)
        {
            if(i % 400 == 0 || i % 4 == 0 && i % 100 != 0)
            {
                return true;
            }
            return false;
        }
        #endregion

        static void Main(string[] args)
        {
            Console.WriteLine("函数练习题");
            Random r = new Random();
            int a = r.Next(0,100);
            int b = r.Next(0,100);
            //练习题一
            Console.WriteLine("练习题一");
            Console.WriteLine("a的值是{0},b的值是{1},最大值是{2}",a,b, Max(a, b));
            Console.WriteLine();

            //练习题二
            Console.WriteLine("练习题二");
            float r1 = r.Next(1,6);
            float[] fl = AreaZc(r1);
            Console.WriteLine("这个原的半径是{0},面积是{1},周长是{2}", r1, fl[0], fl[1]);
            Console.WriteLine();

            //练习题三
            Console.WriteLine("练习题三");
            int M = r.Next(1,11);
            int[] array = new int[M];
            for (int i = 0; i < array.Length; i++)
            {
                int x = r.Next(0, 11);
                array[i] = x;
                Console.Write(array[i] + " ");
            }
            int[] arr = SumMaxMinAvg(array);
            Console.WriteLine("这个数组的总和为{0}，最大值是{1}，最小值是{2}，平均值是{3}", arr[0], arr[1], arr[2], arr[3]);
            Console.WriteLine();

            //练习题四
            Console.WriteLine("练习题四");
            int i4 = r.Next(2,100);
            Console.WriteLine(IsPrimeNum(i4));
            //第二种方法
            Console.WriteLine("{0}{1}质数",i4,IsPrimeNum2(i4)?"是":"不是");
            Console.WriteLine();

            //练习题五
            Console.WriteLine("练习题五");
            try
            {
                Console.WriteLine("请输入年份");
                int year = int.Parse(Console.ReadLine());
                Console.WriteLine(IsLeapYear(year));
            }
            catch
            {
                Console.WriteLine("请输入正确的类型");
            }
            //第二种方法
            int i5 = r.Next(1,2026);
            Console.WriteLine("{0}{1}闰年", i5, IsLeapYear2(i5) ? "是" : "不是");
        }
    }
}
