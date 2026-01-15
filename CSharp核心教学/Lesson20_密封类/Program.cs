using System;

namespace Lesson20_多态_密封方法
{
    #region 知识回顾
    //密封类
    //用sealed修饰的类
    //让类不能再被继承"结扎"
    #endregion

    #region 知识点一 密封方法基本概念
    //用密封关键字sealed 修饰的重写函数
    //作用:让虚方法或者抽象方法之后不能再被重写
    //特点:和override一起出现
    #endregion

    #region 知识点二 实例
    abstract class Animal
    {
        public string name;
        public abstract void Eat();
        public virtual void Speak()
        {
            Console.WriteLine("吃");
        }
    }
    
    class Person : Animal
    {
        public sealed override void Eat()
        {

        }

        public override void Speak()
        {

        }
    }

    class WhitePerson : Person
    {
        //密封不能被重写
        //public override void Eat()
        //{

        //}
        public override void Speak()
        {
            base.Speak();
        }
    }
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("密封方法");
        }
    }
}
