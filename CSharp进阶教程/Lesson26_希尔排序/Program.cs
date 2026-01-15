using System;

namespace Lesson26_希尔排序
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("希尔排序");

            #region 知识点一 希尔排序的基本原理
            //希尔排序是
            //插入排序的升级版
            //必须先掌握插入排序

            //希尔排序的原理
            //将整个待排序序列
            //分割成为若干子序列
            //分别进行插入排序

            //总而言之
            //希尔排序对插入排序的升级主要就是加入了一个步长的概念
            //通过步长每次可以把原序列分为多个子序列
            //对子序列进行插入排序
            //在极限情况下可以有效降低普通插入排序的时间复杂度
            //提升算法效率
            #endregion

            #region 知识点二 代码实现
            int[] arr = new int[] { 8, 7, 1, 5, 4, 2, 6, 3, 9 };
            //学习希尔排序的前提条件
            //先掌握插入排序
            //第一步：实现插入排序
            //第一层循环是用来取出未排序区中的元素的
            //for (int i = 1; i < arr.Length; i++)
            //{
            //    int noSortNum = arr[i];
            //    int sortIndex = i - 1;
            //    while (sortIndex >= 0 &&
            //        arr[sortIndex] > noSortNum)
            //    {
            //        arr[sortIndex + 1] = arr[sortIndex];
            //        sortIndex--;
            //    }
            //    arr[sortIndex + 1] = noSortNum;
            //}

            //第二步：确定步长
            //基本规则：每次步长变化都是/2
            //一开始步长就是数组的长度/2
            //之后每一次都是在上一次的步长基础上/2
            //结束条件是步长<=0
            //1.第一次的步长是数组长度/2所以：intstep=arr.length/2
            //2.之后每一次步长变化都是/2索引l：step/=2
            //3.最小步长是1所以：step>e
            for (int step = arr.Length / 2;step > 0;step /= 2)
            {
                // 注意：
                //每次得到步长后会把该步长下所有序列都进行插入排序

                //第三步：执行插入排序
                for (int i = step; i < arr.Length; i++)
                {
                    int noSortNum = arr[i];

                    int sortIndex = i - step;

                    while (sortIndex >= 0 &&
                        arr[sortIndex] > noSortNum)
                    {
                        arr[sortIndex + step] = arr[sortIndex];
                        sortIndex -= step;
                    }

                    arr[sortIndex + step] = noSortNum;
                }
            }
           
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            #endregion

            #region 知识点三 总结
            //基本原理
            //设置步长
            //步长不停缩小
            //到1排序后结束

            //具体排序方式
            //插入排序原理

            //套路写法
            // 三层循环
            //一层获取步长
            //一层获取未排序区元素
            //一层找到合适位置插入

            //注意事项
            //步长确定后
            //会将所有子序列进行插入排序
            #endregion
        }
    }
}
