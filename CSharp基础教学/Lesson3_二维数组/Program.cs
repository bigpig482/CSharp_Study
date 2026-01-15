using System;

namespace Lesson3_二维数组
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("二维数组");

            #region 知识点一 基本概念
            //二维数组 是使用两个下标（索引）来确定元素的数组
            //两个下标可以理解成 行标 和 列标
            //比如矩阵
            //1 2 3
            //4 5 6
            //可以用二维数组 int[2,3]表示
            //好比 两行 三列的数据集合
            #endregion

            #region 知识点二 二维数组的申明
            //变量类型[,] 二维数组变量名;
            int[,] arr;

            //变量类型[,] 二维数组变量名 = new 变量类型[行,列];
            int[,] arr2 = new int[2, 3];

            //变量类型[,] 二维数组变量名 = new 变量类型[,]{{0行内容1，0行内容2，0行内容3......},{1行内容1，1行内容2，1行内容3......}......};
            int[,] arr3 = new int[3, 3] { {1,2,3 },
                                          {4,5,6 },
                                          { 7,8,9} };

            //变量类型[,] 二维数组变量名 = new 变量类型[,]{{0行内容1，0行内容2，0行内容3......},{1行内容1，1行内容2，1行内容3......}......};
            int[,] arr4 = new int[,] { { 1,2,3},
                                       { 4,5,6}};

            //变量类型[,] 二维数组变量名 ={{0行内容1，0行内容2，0行内容3......},{1行内容1，1行内容2，1行内容3......}......};
            int[,] arr5 = { { 1,2,3 },
                            { 4,5,6 },
                            { 7,8,9}};
            #endregion

            #region 知识点三 二维数组的使用
            int[,] array = new int[,] { { 1, 2, 3 },
                                        { 4, 5, 6} };
            //1.二维数组的长度
            //我们要获取 行和列分别是多长
            //得到多少行
            Console.WriteLine(array.GetLength(0));
            //得到多少列
            Console.WriteLine(array.GetLength(1));

            //2.获取二维数组中的元素
            //注意: 第一个元素的索引是0 最后一个元素的索引 肯定是长度 - 1
            Console.WriteLine(array[0,1]);
            Console.WriteLine(array[1,2]);

            //3.修改二维数组中的元素
            array[0, 0] = 99;
            Console.WriteLine(array[0, 0]);

            Console.WriteLine("-----------------");
            //4.遍历二维数组
            for(int i = 0;i < array.GetLength(0);i++)
            {
                for(int j = 0;j < array.GetLength(1);j++)
                {
                    Console.Write(array[i,j] + " ");
                }
                Console.WriteLine();
            }

            //5.增加数组的元素
            int[,] array2 = new int[3, 3];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array2[i,j] = array[i,j];
                }
            }
            array = array2;
            array[2, 1] = 1;

            Console.WriteLine("-----------------");
            //6.删除数组的元素
            int[,] array3 = new int[2, 3];
            for (int i = 0; i < array3.GetLength(0); i++)
            {
                for (int j = 0; j < array3.GetLength(1); j++)
                {
                    array3[i, j] = array[i, j];
                }
            }
            array = array3;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }

            //7.查找数组中的元素
            int a = 3;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i,j] == a)
                    {
                        Console.WriteLine("这个数在第{0}行第{1}列",i ,j);
                    }
                }
                
            }
            #endregion

            //总结:
            //1.概念:同一变量类型的 行列数据集合
            //2.一定要掌握的内容: 申明 遍历 增删改查
            //3.所有的变量类型都可以申明为 二维数组
            //4.游戏中一般用来存储 矩阵，再控制台小游戏中可以用二维数组 来表示地图格子
        }
    }
}
