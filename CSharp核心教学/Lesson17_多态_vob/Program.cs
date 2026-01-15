using System;

namespace Lesson17_多态_vob
{
    #region 知识点一 多态的概念
    //多态按字面的意思就是“多种状态”
    //让继承同一父类的子类们 在执行相同方法时有不同的表现(状态)
    //主要目的
    //同一父类的对象 执行相同行为(方法)有不同的表现
    //解决的问题
    //让同一个对象有唯一行为特征
    #endregion

    #region 知识点二 解决的问题
    class Father
    {
        public void SpeakName()
        {
            Console.WriteLine("父类的方法");
        }
    }

    class Son : Father
    {
        public new void SpeakName()
        {
            Console.WriteLine("子类的方法");
        }
    }
    #endregion

    #region 知识点三 多态的实现
    //我们目前已经学过的多态
    //编译时多态—函数重载,开始就写好的

    //我们将学习的:
    //运行时多态(vob、抽象函数、接口)
    //我们今天学习 vob
    //v:virtual（虚函数）
    //o:override（重写）
    //b:base（父类）

    class GameObject
    {
        public string name;
        public GameObject(string name)
        {
            this.name = name;
        }
        //虚函数
        public virtual void Atk()
        {
            Console.WriteLine("游戏对象进行攻击");
        }


    }

    class Player : GameObject
    {
        public Player(string name):base(name)
        {

        }
        //重写虚函数
        public override void Atk()
        {
            //base的作用
            //通过base保留父类的行为
            //base.Atk();
            Console.WriteLine("玩家的攻击");
        }
    }
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vob");

            #region 解决的问题
            Father f = new Son();
            f.SpeakName();
            #endregion

            #region 多态的使用
            GameObject g = new Player("小明");
            g.Atk();
            #endregion
        }
    }
    //总结:
    //多态:让同一类型的对象,执行相同行为时有不同的表现
    //解决的问题:让同一对象有唯一的行为特征
    //vob:
    //v: virtual 虚函数
    //o: override 重写
    //b: base 父类
    //v和o一定是结合使用的 来实现多态
    //b是否使用根据实际需求 保留父类行为
}