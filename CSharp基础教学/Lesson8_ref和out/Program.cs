using System;
using System.Security.Cryptography.X509Certificates;

namespace Lesson8_ref和out
{
    class Program
    {
        #region 知识点一 学习ref和out的原因
        //学习ref和out的原因
        //它们可以解决 在函数内部改变外部传入的内容 里面变了 外面也要变

        static void ChangeValue(int value)
        {
            value = 3;
        }

        static void ChangeArrayValue(int[] arr)
        {
            arr[0] = 99;
        }

        static void ChangeArray(int[] arr)
        {
            arr = new int[] { 10, 20, 30 };
        }
        #endregion

        #region 知识的二 ref和out的使用
        //函数参数的修饰符
        //当传入的值类型参数在内部修改时 或者引用类型参数在内部重新申明时
        //外部的值会发生变化

        //ref
        //static void ChangeValueRef(ref int value)
        //{
        //    value = 3;
        //}

        static int ChangeValueRef(ref int value)
        {
            return value = 3;
        }

        static void ChangeArrayRef(ref int[] arr)
        {
            arr = new int[] { 100, 200, 300 };
        }

        //out
        static void ChangeValueOut(out int value)
        {
            value = 3;
        }

        static void ChangeArrayOut(out int[] arr)
        {
            arr = new int[] { 100, 200, 300 };
        }

        #endregion

        #region 知识点三 ref和out的区别
        //1.ref传入的变量必须初始化 out不用
        //2.out传入的变量必须在内部赋值 ref不用

        //ref传入的变量必须初始化 但是在内部 可改可不改
        //out传入的变量不用初始化 但是在内部 必须修改改值（必须赋值）
        #endregion

        #region 练习题
        //让用户输入用户名和密码，返回给用户一个bool类型的登陆结果，并且
        //还要单独的返回给用户一个登陆信息。
        //如果用户名错误，除了返回登陆结果之外，登陆信息为“用户名错误”
        //如果密码错误，除了返回登陆结果之外，登陆信息为“密码错误”
        static bool LoginResult(string user,int pwd,ref string info)
        {
            if(user == "admin")
            {
                if (pwd == 8888)
                {
                    info = "登录成功";
                }
                else
                {
                    info = "密码错误";
                    return false;
                }
            }
            else
            {
                info = "用户名错误";
                return false;
            }
            return true;
        }
        #endregion

        static void Main(string[] args)
        {
            Console.WriteLine("ref和out");
            //并没有改变a的值 在函数中只是拷贝并改变了自己分配的那一部分
            int a = 1;
            ChangeValue(a);
            Console.WriteLine(a);

            //1.ref传入的变量必须初始化 out不用
            int b;
            //ChangeValueRef(ref b);错误
            ChangeValueOut(out b);

            //ref
            ChangeValueRef(ref a);
            Console.WriteLine(a);
            //out
            ChangeValueOut(out a);
            Console.WriteLine(a);

            Console.WriteLine("--------------------");

            //改变了
            int[] arr2 = { 1, 2, 3 };
            ChangeArrayValue(arr2);
            Console.WriteLine(arr2[0]);

            Console.WriteLine("--------------------");
            //没改变
            ChangeArray(arr2);
            Console.WriteLine(arr2[0]);
            //ref
            ChangeArrayRef(ref arr2);
            Console.WriteLine(arr2[0]);
            //out
            ChangeArrayOut(out arr2);
            Console.WriteLine(arr2[0]);

            #region 练习题
            try
            {
                string info = " ";
                Console.WriteLine("请输入用户名和密码");
                string userName = Console.ReadLine();
                int pwd = int.Parse(Console.ReadLine());
                while(!LoginResult(userName, pwd, ref info))
                {
                    Console.WriteLine(info);
                    Console.WriteLine("请输入用户名和密码");
                    userName = Console.ReadLine();
                    pwd = int.Parse(Console.ReadLine());
                }
                Console.WriteLine(info);
            }
            catch
            {
                Console.WriteLine("请输入正确的类型");
            }
            #endregion
        }
    }
}
