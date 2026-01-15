using System;

namespace Lesson4_交错数组
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("交错数组");

            #region 知识点一 基本概念
            //交错数组 是 数组的数组，每个维度的数量可以不同

            //注意：二维数组的每行的列数相同，交错数组每行的列数可能不同
            #endregion

            #region 知识点二 数组的申明
            //变量类型[][] 交错数组名;
            int[][] arr;

            //变量类型[][] 交错数组名 = new 变量类型[行][];
            int[][] arr2 = new int[3][];

            //变量类型[][] 交错数组名 = new 变量类型[行][]{一维数组1,一维数组2,......};
            int[][] arr3 = new int[3][] { new int[] { 1,2,3},
                                          new int[] { 1,2},
                                          new int[] { 1} };

            //变量类型[][] 交错数组名 = new 变量类型[][]{一维数组1,一维数组2,......};
            int[][] arr4 = new int[][] { new int[] { 1,2,3},
                                          new int[] { 1,2},
                                          new int[] { 1} };

            //变量类型[][] 交错数组名 = {一维数组1,一维数组2,......};
            int[][] arr5 = { new int[] { 1,2,3},
                             new int[] { 1,2},
                             new int[] { 1} };
            #endregion

            #region 知识点三 数组的使用
            int[][] array = { new int[] { 1,2,3},
                              new int[] { 4,5} };
            //1.数组的长度
            //行
            Console.WriteLine(array.GetLength(0));
            //得到某一行的列数
            Console.WriteLine(array[0].Length);

            //2.获取交错数组中的元素
            Console.WriteLine(array[0][1]);

            //3.修改交错数组中的元素
            array[0][1] = 99;
            Console.WriteLine(array[0][1]);

            //4.遍历交错数组
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("---------------------------");
            //5.增加交错数组的元素
            int[][] array2 = new int[3][];
            for (int i = 0;i < array.GetLength(0); i++)
            {
                // 为array2的第i行初始化一个数组，长度与array[i]相同
                array2[i] = new int[array[i].Length];

                for (int j = 0;j < array[i].Length; j++)
                {
                    array2[i][j] = array[i][j];
                }
            }

            array2[2] = new int[3] { 1, 2, 3 };

            array = array2;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("---------------------------");
            //6.删除交错数组的元素
            int[][] array3 = new int[array.Length - 1][]; // 行数减1

            for (int i = 0; i < array3.Length; i++)
            {
                array3[i] = new int[array[i].Length]; // 按照原数组对应行的长度创建
                for (int j = 0; j < array[i].Length; j++)
                {
                    array3[i][j] = array[i][j];
                }
            }

            array = array3;

            // 遍历输出
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j] + " ");
                }
                Console.WriteLine();
            }

            //7.查找交错数组中的元素
            int a = 3;
            for (int i = 0;i < array.GetLength(0); i++)
            {
                for(int j = 0;j < array[i].Length; j++)
                {
                    if (a == array[i][j])
                    {
                        Console.Write("这个数在第{0}行第{1}列",i,j);
                    }
                }
            }
            #endregion

            //总结
            //1.概念:交错数组 可以存储同一类型的m行不确定列的数据
            //2.一定要掌握的内容：申明、遍历、增删改查
            //3.所有的变量类型都可以申明为 交错数组
            //4.一般交错数组很少使用 了解即可

        }
    }
}