using System;

namespace Lesson7_练习题
{
    #region 练习题1
    //请说出const和static的区别

    //相同点:
    //都可以直接通过类点出来使用
    //不同点:
    //1.const必须初始化 不能修改 static没有这个规则
    //2.const只能修饰变量 static能修饰很多
    //3.const不能写在修饰符前面 必须写在申明变量的前面 static没有这个规则
    #endregion

    //111
    #region 练习题2
    //一个类对象，在整个应用程序的生命周期中，有且仅会有一个该对象的
    //存在，不能在外部实例化，直接通过该类类名就能够得到唯一的对象数
    class Test
    {
        private static Test t = new Test();

        public static Test T
        {
            get
            {
                return t;
            }
        }

        private Test()
        {

        }

        public void Speak()
        {
            Console.WriteLine("你好");
        }
    }
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("静态成员练习题");
            //Test t = new Test();
        }
    }
}