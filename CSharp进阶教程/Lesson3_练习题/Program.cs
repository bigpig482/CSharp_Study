using System;
using System.Collections;

namespace Lesson3_练习题
{
    #region 练习题1
    //请简述队列的存储规则

    //先进先出
    #endregion

    #region 练习题2
    //使用队列存储信息，一次性存10条信息，每隔一段时间打印一条信息
    //控制台打印信息时要有明显停顿感
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Queue练习题");
            Print();
        }

        static void Print()
        {
            Queue q = new Queue();
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            q.Enqueue(4);
            q.Enqueue(5);
            q.Enqueue(6);
            q.Enqueue(7);
            q.Enqueue(8);
            q.Enqueue(9);
            q.Enqueue(10);

            //循环出列
            int num = 1;
            while (q.Count > 0)
            {
                while (num % 2000000000 == 0)
                {
                    Console.WriteLine(q.Dequeue());
                    num = 1;
                }
                num++;
            }
            
        }
    }
}
