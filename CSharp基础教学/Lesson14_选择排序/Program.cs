using System;

namespace Lesson14_选择排序
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("选择排序");
            #region 知识点一 选择排序基本原理
            // 8 7 1 5 4 2 6 3 9
            //新建中间商
            //依次比较
            //找出极值（最大或最小）
            //放入目标位置
            //比较n轮
            #endregion

            #region 知识点二 代码实现
            //实现升序 把 大的 放在最后面
            int[] arr = new int[] { 8, 7, 1, 5, 4, 2, 6, 3, 9 };
            int temp;
            //第五步 比较j轮
            for(int j = 0;j < arr.Length;j++)
            {
                //第一步 申明一个中间商 来记录索引
                //每一轮开始 默认第一个都是极值
                int index = 0;
                //第二步
                for (int i = 1; i < arr.Length - j; i++)
                {
                    //第三步 找出极值
                    if (arr[index] < arr[i])
                    {
                        index = i;
                    }
                }

                //第四步 放入目标位置
                //如果当前极值所在位置 就是目标位置 就不用交换了
                if(index != arr.Length - 1 - j)
                {
                    temp = arr[index];
                    arr[index] = arr[arr.Length - 1 - j];
                    arr[arr.Length - 1 - j] = temp;
                }
            }

            //打印验证
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            #endregion
        }
    }
}
