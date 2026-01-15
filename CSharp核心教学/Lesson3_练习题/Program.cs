using System;
using System.Globalization;

namespace Lesson3_练习题
{
    #region 练习题1
    //基于成员变量练习题
    //为人类定义说话、走路、吃饭等方法
    class Person 
    {
        public string name;

        public void Speak(string str)
        {
            Console.WriteLine("{0}说{1}",name,str);
        }

        public void Run()
        {

        }

        public void Eat(Food f)
        {
            Console.WriteLine("{0}吃了{1},一共有{2}热量", name, f.name, f.Calories);
        }
    }
    #endregion

    #region 练习题2
    //基于成员变量练习题
    //为学生类定义学习、吃饭等方法
    class Student
    {
        public string name;

        public void Study()
        {

        }

        public void Eat(Food f)
        {
            Console.WriteLine("{0}吃了{1},一共有{2}热量",name,f.name,f.Calories);
        }
    }

    #endregion

    #region 练习题3
    //定义一个食物类，有名称，热量等特征
    //思考如何和人类以及学生类联系起来
    class Food()
    { 
        public string name;
        public int Calories;

        public void BeiEat(Person p)
        {
            Console.WriteLine("{0}被{1}吃了", name, p.name);
        }
        public void BeiEat(Student s)
        {
            Console.WriteLine("{0}被{1}吃了", name, s.name);
        }
    }
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("成员方法练习题");

            Person p = new Person();
            p.name = "秦靖杰";

            Student s = new Student();
            s.name = "王俊豪";

            Food f = new Food();
            f.name = "热狗";
            f.Calories = 100;

            p.Speak("我是sb");
            p.Eat(f);

            s.Eat(f);

            f.BeiEat(p);
            f.BeiEat(s);
        }
    }
}