#define Unity5
#define Unity2017
#define Unity2020

using System;

namespace Lesson19_练习题
{
    #region 练习题1
    //请说出至少4种预处理器指令
    //#region
    //#endregion
    //#define
    //#undef
    //#if
    //#elif
    //#else
    //#endif
    //#warning
    //#error
    #endregion

    #region 练习题2
    //请便用预处理器指令实现
    //写一个函数计算两个数
    //当是Unity5版本时算加法
    //当是Unity2017版本时算乘法
    //当时Unity2020版本时算减法
    //都不是返回0
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("预处理器指令练习题");
            Console.WriteLine(Fun(3,4));
        }
        static int Fun(int a,int b)
        {
            #if Unity5
            return a + b;
            #elif Unity2017
            return a * b;
            #elif Unity2020
            return a - b;
            #else
            return 0;
            #endif
        }
    }
}
