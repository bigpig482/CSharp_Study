using System;

namespace Lesson5_练习题
{
    #region 练习题
    //定义一个泛型方法，方法内判断该类型为何类型，并返回类型的名称与
    //占有的字节数，如果是int，则返回“整形，4字节”
    //只考虑以下类型
    //int：整形
    //char:字符
    //float:单精度浮点数
    //string:字符串
    //如果是其它类型，则返回“其它类型”
    //（可以通过typeof(类型）==typeof(类型) 的方式进行类型判断）
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("泛型练习题");
            DetermineType<int>(1);
            DetermineType<char>('A');
            DetermineType<float>(2.1f);
            DetermineType<string>("你好");
            DetermineType<uint>(10);
        }

        public static void DetermineType<T>(T t)
        {
            if(typeof(T) == typeof(int))
            {
                Console.WriteLine("{0}是整形,{1}字节",t,sizeof(int));
            }
            else if(typeof(T) == typeof(char))
            {
                Console.WriteLine("{0}是字符,{1}字节", t, sizeof(char));
            }
            else if (typeof(T) == typeof(float))
            {
                Console.WriteLine("{0}是单精度浮点数,{1}字节", t, sizeof(float));
            }
            else if ((typeof(T) == typeof(string)))
            {
                Console.WriteLine("{0}是字符串,变长字节",t);
            }
            else
            {
                Console.WriteLine("{0}是其他类型,未知字节", t);
            }
        }
    }
}
