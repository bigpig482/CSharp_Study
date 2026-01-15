using System;

namespace Lesson14_练习题
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("选择排序练习题");
            #region 练习题1
            //定义一个数组，长度为20，每个元素值随机0~100的数
            //使用选择排序进行升序排序并打印
            //使用选择排序进行降序排序并打印

            int[] arr = new int[20];
            Random r = new Random();
            int temp;
            int index;
            //赋值
            for(int i = 0;i < arr.Length;i++)
            {
                arr[i] = r.Next(0,101);
            }

            //打印
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            //升序
            //for(int j = 0;j < arr.Length;j++)
            //{
            //    index = 0;
            //    for (int i = 1;i < arr.Length - j;i++)
            //    {
            //        if(arr[index] < arr[i])
            //        {
            //            index = i;
            //        }
            //    }

            //    if (index != arr.Length - 1 - j)
            //    {
            //        temp = arr[index];
            //        arr[index] = arr[arr.Length - 1 - j];
            //        arr[arr.Length - 1 - j] = temp;
            //    }
            //}

            for(int i = 0;i < arr.Length;i++)
            {
                index = 0;
                for(int j = 1;j < arr.Length - i;j++)
                {
                    if (arr[index] < arr[j])
                    {
                        index = j;
                    }
                }
                if(index != arr.Length - 1 - i)
                {
                    temp = arr[index];
                    arr[index] = arr[arr.Length - 1 - i];
                    arr[arr.Length - 1 - i] = temp;
                }
            }

            //打印
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            //降序
            for (int j = 0;j < arr.Length;j++)
            {
                index = 0;
                for(int i = 0;i < arr.Length - j;i++)
                {
                    if (arr[index] > arr[i])
                    {
                        index = i;
                    }
                }
                if(index != arr.Length - 1 - j)
                {
                    temp = arr[index];
                    arr[index] = arr[arr.Length - 1 - j];
                    arr[arr.Length - 1 -j] = temp;
                }
            }

            //打印
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            #endregion
        }
    }
}
