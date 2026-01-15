using System;

namespace Lesson25_插入排序
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("插入排序");
            #region 知识回顾
            //int[] array = new int[] { 8, 2, 7, 6, 5, 1, 4, 3 };
            //int temp;
            //bool isSort = false;
            //for (int i = 0; i < array.Length; i++)
            //{
            //    isSort = false;
            //    for (int j = 0; j < array.Length - 1 - i; j++)
            //    {
            //        if (array[j] > array[j + 1])
            //        {
            //            isSort = true;
            //            temp = array[j];
            //            array[j] = array[j + 1];
            //            array[j + 1] = temp;
            //        }
            //    }
            //    if (!isSort)
            //    {
            //        break;
            //    }
            //}

            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write(array[i] + " ");
            //}

            //Console.WriteLine();
            //int index;
            //for (int i = 0; i < array.Length; i++)
            //{
            //    index = 0;
            //    for (int j = 1; j < array.Length - i; j++)
            //    {
            //        if (array[index] > array[j])
            //        {
            //            index = j;
            //        }
            //    }
            //    if (index != array.Length - 1 - i)
            //    {
            //        temp = array[index];
            //        array[index] = array[array.Length - 1 - i];
            //        array[array.Length - 1 - i] = temp;
            //    }
            //}

            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write(array[i] + " ");
            //}
            #endregion

            #region 知识点一 插入排序的基本原理
            // 8 7 1 5 4 2 6 3 9
            // 两个区域
            // 排序区
            // 未排序区
            // 用一个索引值做分水岭

            // 未排序区元素
            // 与排序区元素比较
            // 插入到合适位置
            // 直到未排序区清空
            #endregion

            #region 知识点二 代码实现
            //实现排序
            int[] arr = new int[] { 8, 7, 1, 5, 4, 2, 6, 3, 9 };
            //前提规则
            //排序开始前
            //首先认为第一个元素在排序区中
            //其它所有元素在未排序区中

            //排序开始后
            //每次将未排序区第一个元素取出用于和
            //排序区中元素比较（从后往前）
            //满足条件（较大或者较小）
            //则排序区中元素往后移动一个位置。

            //注意
            //所有数字都在一个数组中
            //所谓的两个区域是一个分水岭索引

            // 第一步
            //能取出未排序区的所有元素进行比较
            //i=1的原因：默认第一个元素就在排序区
            for (int i = 1; i < arr.Length; i++)
            {
                // 第二步
                // 每一轮
                //1.取出排序区的最后一个元素索引
                int sortIndex = i - 1;
                //2.取出未排序区的第一个元素
                int noSortNum = arr[i];

                //第三步
                //在未排序区进行比较
                //移动位置
                //确定插入索引
                //循环停止的条件
                //1.发现排序区中所有元素都已经比较完
                //2.发现排序区中的元素不满足比较条件了
                while(sortIndex >= 0 &&
                    arr[sortIndex] > noSortNum)
                {
                    //只要进了这个while循环证明满足条件
                    //排序区中的元素就应该往后退一格
                    arr[sortIndex + 1] = arr[sortIndex];
                    //移动到排序区的前一个位置 准备继续比较
                    --sortIndex;
                }
                //最终插入数字
                //循环中知识在确定位置和找最终的插入位置
                //最终插入对应位置应该循环结束后
                arr[sortIndex + 1] = noSortNum;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            #endregion

            #region 知识点三 总结

            #endregion
        }
    }
}
