using System;

namespace Lesson9_变长参数和默认值
{
    class Program
    {
        #region 知识点一 函数语法复习
        //    1       2       3                       4
        // static 返回类型 函数名(参数类型 参数名1,函数参数 参数类型 参数名2, ......)
        //{
        //       函数的代码逻辑;
        //       函数的代码逻辑;
        //       函数的代码逻辑;
        //       .......
        //           5
        //       return 返回值;(如果有返回类型才返回)
        //}
        //1.静态关键词 可选，目前对于我们来说必须写
        //2.返回值，没有返回值填void，可以填写任意类型的变量
        //3.函数名，帕斯卡命名法
        //4.参数可以是0~n个 前面可以加 ref和out 用来传递想要在函数内部改变内容的变量
        //5.如果返回值不是void 那么必须有return对应类型的内容 return可以打断函数语句块中的逻辑 直接停止后面的逻辑

        #endregion

        #region 知识点二 变长参数关键词
        //举例 函数要计算 n个整数的和
        //static int Sum(int a,int b,.......)

        //变长参数关键字 params
        static int Sum(params int[] arr)
        {
            int sum = 0;
            for (int i = 0;i < arr.Length;i++)
            {
                sum += arr[i];
            }
            return sum;
        }

        //params int[] 意味着可以传入n个int参数 n可以等于0 传入的参数会存在arr数组中
        //注意:
        //1.params关键字后面必为数组
        //2.数组的类型可以是任意的类型

        //3.函数参数可以有 别的参数和 params关键字修饰的参数
        //4.函数参数中只能最多出现一个params关键字 并且一定是在最后一组参数 前面可以有n个其它参数
        static void Eat(string name,params string[] things)
        {

        }
        #endregion

        #region 知识点三 参数默认值
        //有参数默认值的参数 一般称为可选参数
        //作用是 当调用函数时可以不传入参数，不传就会使用默认值作为参数的值

        static void Speak(string str = "我无话可说")
        {
            Console.WriteLine(str);
        }

        //注意：
        //1.支持多参数默认值 每个参数都可以有默认值
        //2.如果要混用 可选参数 必须写在 普通参数后面

        static void Speak2(int test ,string name = "111",string str = "我无话可说")
        {
            Console.WriteLine(str);
        }
        #endregion

        //总结
        //1 变长参数关键词 params
        //作用： 可以传入n个同类型参数 n可以是0
        //注意：
        //1.params后面必须是数组，意味着只能是同一类型的可变参数
        //2.变长参数只能有一个
        //3.必须在所有参数最后写变长参数

        //2 参数默认值(可选参数)
        //作用:可以给参数默认值 使用时可以不传参 不传用默认的 传了用传的
        //注意：
        //1.可选参数可以有多个
        //2.正常参数比写在可选参数前面，可选参数只能写在所有参数的后面

        static void Main(string[] args)
        {
            Console.WriteLine("变长参数和默认值");

            Sum();
            Console.WriteLine(Sum(1,2,3,4,5,6));

            Speak();
            Speak("123456789");
        }
    }
}
