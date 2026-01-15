using System;

namespace Lesson15_练习题
{
    #region 练习题1
    //请口头描述什么是装箱拆箱
    //装箱
    //把值类型用引用类型存储
    //栈内存迁移到堆内存中
    //拆箱
    //把引用类型存储的值类型取出来
    //堆内存迁移到栈内存中
    #endregion

    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("万物之父和装箱拆箱练习题");
            #region 练习题2
            //请用代码描述装箱拆箱
            //装箱
            int i = 10;
            object obj = i;
            i = (int)obj;
            #endregion
        }
    }
}
