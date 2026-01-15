using System;

namespace Lesson10_练习题
{
    #region 练习题
    //使用Linkedlist，向其中加入10个随机整形变量
    //正向遍历一次打印出信息
    //反向遍历一次打印出信息
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LinkedList练习题");
            Random r = new Random();
            int rNum;
            LinkedList<int> list = new LinkedList<int>();
            for (int i = 0;i < 10;i++)
            {
                rNum = r.Next(0,100);
                list.AddLast(rNum);
            }

            LinkedListNode<int> first = list.First;
            while (first != null)
            {
                Console.WriteLine(first.Value);
                first = first.Next;
            }
            Console.WriteLine("------------------------");
            first = list.Last;
            while (first != null)
            {
                Console.WriteLine(first.Value);
                first = first.Previous;
            }
        }
    }
}
