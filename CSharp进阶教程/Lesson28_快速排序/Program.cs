using System;

namespace Lesson28_快速排序
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("快速排序");
            int[] arr = new int[] { 8, 7, 1, 5, 4, 2, 6, 3, 9 };
            QuickSort(arr,0,arr.Length - 1);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        #region 知识点一 快速排序基本原理
        //选取基准
        //产生左右标识
        //左右比基准
        //满足则换位

        //排完一次
        //基准定位

        //左右递归
        //直到有序
        #endregion

        #region 知识点二 代码实现
        //第一步:
        //申明用于快速排序的函数
        public static void QuickSort(int[] array,int left,int right)
        {
            //第七步:
            //递归函数结束条件
            if (left >= right)
                return;

            //第二步:
            //记录基准值
            //左游标
            //右游标
            int tempLeft, tempRight, temp;
            temp = array[left];
            tempLeft = left;
            tempRight = right;

            //第三步:
            //核心交换逻辑
            //左右游标会不同变化要不相同时才能继续变化
            while(tempLeft != tempRight)
            {
                //第四步 比较位置交换
                //首先从右边开始找 比较 看值有没有资格放到标识的右侧
                while (tempLeft < tempRight &&
                    array[tempRight] > temp)
                {
                    tempRight--;
                }
                //移动结束证明可以换位置
                array[tempLeft] = array[tempRight];

                //上面是移动右游标
                //接下来移动左游标
                while(tempLeft < tempRight &&
                    array[tempLeft] < temp)
                {
                    tempLeft++;
                }
                //移动结束证明可以换位置
                array[tempRight] = array[tempLeft];
            }

            //第五步：放置基准值
            //跳出循环后把基准值放在中间位置
            //此时tempRight和tempLeft一定是相等的
            array[tempRight] = temp;

            //第六步:
            //递归继续
            QuickSort(array,left, tempRight - 1);
            QuickSort(array, tempLeft + 1, right);
        }

        #endregion

        #region 知识点三 总结

        #endregion
    }
}
