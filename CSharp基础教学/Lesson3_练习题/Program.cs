using System;

namespace Lesson3_练习题
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("二维数组练习题");

            #region 练习题1
            //将1到10000赋值给一个二维数组（100行100列）

            //int[,] array = new int[100, 100];
            //int index = 1;
            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array.GetLength(1); j++)
            //    {
            //        array[i, j] = index;
            //        index++;
            //    }
            //}

            #endregion

            #region 练习题2
            //将二维数组（4行4列）的右上半部分置零（元素随机1~100）

            //Random r = new Random();
            //int[,] array2 = new int[4, 4];
            //for (int i = 0; i < array2.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array2.GetLength(1); j++)
            //    {
            //        array2[i, j] = r.Next(1, 101);
            //    }
            //}

            //for (int i = 0; i < array2.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array2.GetLength(1); j++)
            //    {
            //        if (i < 2 && j > 1)
            //        {
            //            array2[i, j] = 0;
            //        }
            //        Console.Write(array2[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region 练习题3
            //求二维数组（3行3列）的对角线元素的和（元素随机1~10）

            //int[,] array3 = new int[3, 3];
            //Random r = new Random();
            //for (int i = 0; i < array3.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array3.GetLength(1); j++)
            //    {
            //        array3[i, j] = r.Next(1, 11);
            //    }
            //}

            //int sum = 0;
            //for (int i = 0; i < array3.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array3.GetLength(1); j++)
            //    {
            //        if (i == j || i+j == 2)
            //        {
            //            sum += array3[i, j];
            //        }
            //        Console.Write(array3[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("这个二维数组对角线的和为{0}", sum);

            #endregion

            #region 练习题4
            //求二维数组（5行5列）中最大元素值及其行列号（元素随机1~500）

            //int[,] array4 = new int[5, 5];
            //Random r = new Random();
            //for(int i = 0;i < array4.GetLength(0);i++)
            //{
            //    for(int j = 0;j < array4.GetLength(1);j++)
            //    {
            //        array4[i, j] = r.Next(1,501);
            //    }
            //}

            //int max = array4[0, 0];
            //int h = 0;
            //int l = 0;

            //for (int i = 0; i < array4.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array4.GetLength(1); j++)
            //    {
            //        Console.Write(array4[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 0;i < array4.GetLength(0);i++)
            //{
            //    for (int j = 0;j < array4.GetLength(1);j++)
            //    {
            //        if (array4[i,j] > max)
            //        {
            //            max = array4[i,j];
            //            h = i;
            //            l = j;
            //        }
            //    }
            //}
            //Console.WriteLine("这个二维数值的最大值为{0}，它在第{1}行第{2}列", max, h, l);

            #endregion

            #region 练习题5
            //给一个M* N的二维数组，数组元素的值为O或者1，
            //要求转换数组，将含有1的行和列全部置1

            //Random r = new Random();
            //int M = r.Next(1, 6);
            //int N = r.Next(1, 6);
            //int[,] array5 = new int[M, N];
            //for (int i = 0; i < M; i++)
            //{
            //    for (int j = 0; j < N; j++)
            //    {
            //        array5[i, j] = r.Next(0, 2);
            //    }
            //}

            //for (int i = 0; i < array5.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array5.GetLength(1); j++)
            //    {
            //        Console.Write(array5[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine("------------------------------");
            //bool[] hang = new bool[M];
            //bool[] lie = new bool[N];

            ////bool isHave1 = false;

            //for (int i = 0; i < array5.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array5.GetLength(1); j++)
            //    {
            //        if (array5[i, j] == 1)
            //        {
            //            hang[i] = true;
            //            lie[j] = true;
            //        }
            //    }
            //}

            //for (int i = 0; i < array5.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array5.GetLength(1); j++)
            //    {
            //        if (hang[i] == true || lie[j] == true)
            //        {
            //            array5[i, j] = 1;
            //        }
            //    }
            //}

            //for (int i = 0; i < array5.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array5.GetLength(1); j++)
            //    {
            //        Console.Write(array5[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            #endregion
        }
    }
}
