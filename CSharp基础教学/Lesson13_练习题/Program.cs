using System;

namespace Lesson13_练习题
{
    #region 练习题1
    //定义一个数组，长度为20，每个元素值随机0~100的数
    //使用冒泡排序进行升序排序并打印
    //使用冒泡排序进行降序排序并打印
    #endregion

    #region 练习题2
    //写一个函数，实现一个数组的排序，并返回结果。可以根据参数决定是
    //升序还是降序
    #endregion
    class Program
    {
        static int[] Sort(int[] arr, bool b)
        {
            int temp;
            bool isSort;
            for(int i = 0; i < arr.Length;i++)
            {
                isSort = false;
                for(int j = 0;j < arr.Length - 1 - i;i++)
                {
                    bool b2 = b ? arr[j] > arr[j + 1] : arr[j] < arr[j + 1];
                    if(b2)
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
                if(!isSort)
                {
                    break;
                }
            }
            //for (int m = 0; m < arr.Length; m++)
            //{
            //    isSort = false;
            //    for (int n = 0; n < arr.Length - 1 - m; n++)
            //    {
            //        bool b2 = b ? arr[n] > arr[n + 1] : arr[n] < arr[n + 1];
            //        if (b2)
            //        {
            //            isSort = true;
            //            temp = arr[n];
            //            arr[n] = arr[n + 1];
            //            arr[n + 1] = temp;
            //        }
            //    }
            //    if (!isSort)
            //    {
            //        break;
            //    }
            //}
            return arr;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("冒泡排序练习题");
            #region 练习题1
            Console.WriteLine("练习题1");
            int[] array1 = new int[10];
            Random r = new Random();
            //赋值
            for(int i = 0;i < array1.Length;i++)
            {
                array1[i] = r.Next(0,101);
            }

            //打印验证
            for(int i = 0; i < array1.Length;i++)
            {
                Console.Write(array1[i] + " ");
            }

            //升序
            bool isSort = false;
            int temp;
            for(int m = 0;m < array1.Length;m++)
            {
                isSort = false;
                for(int n = 0;n < array1.Length - 1 - m;n++)
                {
                    if (array1[n] > array1[n + 1])
                    {
                        isSort = true;
                        temp = array1[n];
                        array1[n] = array1[n + 1];
                        array1[n + 1] = temp;
                    }
                    
                }
                if (!isSort)
                {
                    break;
                }
            }

            //打印验证
            Console.WriteLine();
            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write(array1[i] + " ");
            }

            //降序
            for (int m = 0; m < array1.Length; m++)
            {
                isSort = false;
                for (int n = 0; n < array1.Length - 1 - m; n++)
                {
                    if (array1[n] < array1[n + 1])
                    {
                        isSort = true;
                        temp = array1[n];
                        array1[n] = array1[n + 1];
                        array1[n + 1] = temp;
                    }

                }
                if (!isSort)
                {
                    break;
                }
            }

            //打印验证
            Console.WriteLine();
            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write(array1[i] + " ");
            }
            #endregion

            #region 练习题2
            Console.WriteLine();
            Console.WriteLine("练习题2");
            int[] arr2 = Sort(array1,true);
            //打印验证
            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write(arr2[i] + " ");
            }
            #endregion
        }
    }
}
