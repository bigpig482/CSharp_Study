using System;

namespace Lesson15_练习题
{
    #region 练习题
    //有一个函数，会返同一个委托函数，这个委托函数中只有一句打印代码
    //之后执行返回的委托函数时，可以打印出1 ~10
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("lambad表达式练习题");
            TestFun()();
            TestFun2()();
            TestFun3()();
            TestFun4()();
        }
        static Action TestFun()
        {
            return () =>
            {
                for (int i = 1; i <= 10; i++)
                {
                    int index = i;
                    Console.WriteLine(index);
                }
            };
        }

        static Action TestFun2()
        {
            Action a = null;
                for (int i = 1; i <= 10; i++)
                {
                    int index = i;
                    a += () =>
                    {
                        Console.WriteLine(index);
                    };
                }
            return a;
        }

        static Action TestFun3()
        {
            Action a = null;
            for (int i = 1; i <= 10; i++)
            {
                int index = i;
                a += delegate()
                {
                    Console.WriteLine(index);
                };
            }
            return a;
        }

        static Action TestFun4()
        {
            Action a = null;
            for (int i = 1; i <= 10; i++)
            {
                int index = i;
                a += delegate ()
                {
                    Show(index);
                };
            }
            return a;
        }

        static void Show(int i)
        {
            Console.WriteLine(i);
        }
    }
}
