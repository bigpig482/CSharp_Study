using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lesson2_练习题
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("一维数组练习题");

            #region 练习题一
            //请创建一个一维数组并赋值，让其值与下标一样，长度为100

            //int[] array = new int[100];
            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = i;
            //}

            #endregion

            #region 练习题二
            //创建另一个数组B，让数组A中的每个元素的值乘以2存入到数组B中

            //int[] array2 = new int[100];
            //for(int i = 0;i < array.Length; i++)
            //{
            //    array2[i] = array[i] * 2;
            //    Console.WriteLine(array2[i]);
            //}

            #endregion

            #region 练习题三
            //随机（0~100）生成1个长度为10的整数数组

            //Random r = new Random();
            //int i;
            //int max = 0, min = 100,sum = 0,avg;
            //int[] array3 = new int[10];
            //for (int j = 0; j < array3.Length; j++)
            //{
            //    i = r.Next(100);
            //    array3[j] = i;
            //    Console.WriteLine(array3[j]);
            //    if (array3[j] < min)
            //    {
            //        min = array3[j];
            //    }
            //    if (array3[j] > max)
            //    {
            //        max = array3[j];
            //    }
            //    sum += array3[j];
            //}
            //avg = sum / array3.Length;

            //先计算再判断
            //把第一次的值默认为最大最小值
            //int min = array3[0];
            //int max = array3[0];
            //for (int i = 0; i < array3.Length; i++)
            //{
            //    if (array3[j] < min)
            //    {
            //        min = array3[j];
            //    }
            //    if (array3[j] > max)
            //    {
            //        max = array3[j];
            //    }
            //}
            #endregion

            #region 练习题四
            //从一个整数数组中找出最大值、最小值、总合、平均值
            //（可以使用随机数1～100）

            //Console.WriteLine("最大值{0}，最小值{1}，总和{2}，平均值{3}",max,min,sum,avg);
            #endregion

            #region 练习题五
            //交换数组中的第一个和最后一个、第二个和倒数第二个，依次类推，把
            //数组进行反转并打印

            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9};
            //int a = arr[arr.Length - 1];
            //int temp;
            //for (int i = 0; i < arr.Length/2; i++)
            //{
            //    temp = arr[i];
            //    arr[i] = arr[arr.Length - 1 - i];
            //    arr[arr.Length - i - 1] = temp;
            //    //Console.WriteLine(i);
            //}
            //for (int i = 0;i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            #endregion

            #region 练习题六
            //将一个整数数组的每一个元素进行如下的处理：
            //如果元素是正数则将这个位置的元素值加1；
            //如果元素是负数则将这个位置的元素值减1；
            //如果元素是0，则不变

            //int[] arr = { -1, -2, -3, -4, -5, 0, 1, 2, 3, 4, 5 };
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] < 0)
            //    {
            //        arr[i] -= 1;
            //    }
            //    if (arr[i] > 0)
            //    {
            //        arr[i] += 1;
            //    }
            //}
            //for (int i = 0;i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            #endregion

            #region 练习题七
            //定义一个有10个元素的数组，使用for循环，输入10名同学的数学成绩，
            //将成绩依次存入数组，然后分别求出最高分和最低分，并且求出10名同学的数学平均成绩

            //int[] arr = new int[10];
            //int min = 100, max = 0, sum = 0;
            //float avg;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    int Input = int.Parse(Console.ReadLine());
            //    arr[i] = Input;
            //    if (Input < min) min = arr[i];
            //    if (Input > max) max = arr[i];
            //    sum += arr[i];
            //}
            //avg = (float)sum / arr.Length;
            //Console.WriteLine("最大值{0}，最小值{1}，总和{2}，平均值{3}", max, min, sum, avg);

            #endregion

            #region 练习题八
            //请声明一个string类型的数组（长度为25）（该数组中存储着符号），通
            //过遍历数组的方式取出其中存储的符号打印出以下效果

            //string[] arr = new string[25];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if(i % 2 == 0)
            //    {
            //        arr[i] = "A";
            //    }
            //    else
            //    {
            //        arr[i] = "B";
            //    }
            //}

            //for (int k =0;k < arr.Length; k++)
            //{
            //    if (k % 5 == 0 && k!= 0)
            //    {
            //        Console.WriteLine();
            //    }
            //    Console.Write(arr[k]);
            //}

            #endregion
        }
    }
}