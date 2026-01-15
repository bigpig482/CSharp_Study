using System;

namespace Lesson9_练习题
{
    class Program
    {
        #region 练习题一
        //使用params参数，求多个数字的和以及平均数
        static int[] SumAvg(params int[] arr)
        {
            if(arr.Length == 0)
            {
                Console.WriteLine("没有参数");
            }
            int sum = 0;
            int avg = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            avg = sum / arr.Length;
            return new int[] { sum, avg };
        }
        #endregion

        #region 练习题二
        //使用params参数，求多个数字的偶数和和奇数和
        static int[] OSumJSum(params int[] arr)
        {
            int oSum = 0;
            int jSum = 0;
            for(int i = 0;i < arr.Length;i++)
            {
                if (arr[i] % 2 == 0)
                {
                    oSum += arr[i];
                }
                else
                {
                    jSum += arr[i];
                }
            }
            return new int[] { oSum, jSum };
        }
        #endregion
        static void Main(string[] args)
        {
            Console.WriteLine("练习题");
            Console.WriteLine("练习题1");
            int[] array = SumAvg(1,2,3,4,5);
            Console.WriteLine("总和为{0} 平均值为{1} ",array[0], array[1]);

            Console.WriteLine();
            Console.WriteLine("练习题2");
            int[] array2 = OSumJSum(1,2,3,4,5,6,7,8,9,10);
            Console.WriteLine("偶数总和为{0} 奇数总和为{1} ", array2[0], array2[1]);
        }
    }
}