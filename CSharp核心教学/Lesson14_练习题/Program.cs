using System;

namespace Lesson14_练习题
{
    #region 练习题
    //有一个打工人基类，有工种，工作内容两个特征，一个工作方法
    //程序员、策划、美术分别继承打工人
    //请用继承中的构造函数这个知识点
    //实例化3个对象，分别是程序员、策划、美术
    class Worker
    {
        public string occupation;
        public string workInfo;

        public Worker()
        {

        }

        public Worker(string occupation, string workInfo)
        {
            this.occupation = occupation;
            this.workInfo = workInfo;
        }
        public void Work()
        {
            Console.WriteLine("{0}的工作是{1}",occupation,workInfo);
        }
    }

    /// <summary>
    /// 程序员
    /// </summary>
    class Programmer : Worker
    {
        public Programmer() :base("程序员","代码")
        {

        }
    }
    //策划
    class Planning : Worker
    {
        public Planning(string occupation, string workInfo) : base(occupation, workInfo)
        {

        }
    }
    //美术
    class Fineart : Worker
    {
        public Fineart(string occupation, string workInfo) : base(occupation, workInfo)
        {

        }
    }
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("继承中的构造函数练习题");
            Worker w = new Programmer("程序员","代码");
            w.Work();
        }
    }
}
