using System;

namespace Lesson12_练习题
{
    #region 练习题
    //写一个人类,人类中有姓名,年龄属性,有说话行为
    //战士继承人类,有攻击行为
    class Person
    {
        public string name;
        public int age;

        public Person()
        {
            name = "秦靖杰";
            age = 21;
        }
        public Person(string name,int age)
        {
            this.name = name;
            this.age = age;
        }

        public void Speak()
        {
            Console.WriteLine("你好");
        }
    }

    class Warrior : Person
    {
        public void Atk(Person otherp)
        {
            Console.WriteLine("{0}攻击了{1}",name,otherp.name);
        }
    }
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("继承的基本规则练习题");
            Person p = new Person();
            Warrior w = new Warrior();
            w.name = "王俊豪";
            w.age = 21;
            w.Atk(p);
        }
    }
}
