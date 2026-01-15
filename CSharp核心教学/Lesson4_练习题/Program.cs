using System;

namespace Lesson4_练习题
{
    #region 练习题1
    //基于成员方法练习题
    //对人类的构造函数进行重载，用人类创建若干个对象
    class Person
    {
        public string name;
        public int age;

        public Person(string name)
        {
            this.name = name;
        }

        public Person(int age):this()
        {
            this.age = age;
        }
        
        public Person()
        {
            name = "唐老师";
            age = 18;
        }

        public Person(string name,int age)
        {
            this.name = name;
            this.age = age;
        }
    }
    #endregion

    #region 练习题2
    //基于成员变量练习题
    //对班级类的构造函数过行重载，用班级类创建若干个对象
    class Class
    {
        public string name;
        public int stunum;

        public Class(string name,int stunum)
        {
            this.name = name;
            this.stunum = stunum;
        }

        public Class()
        {
            name = "1909";
            stunum = 60;
        }
    }
    #endregion

    #region 练习题3
    //写个Ticket类，有个距离变量（在构造对象时赋值，不能为负
    //数），有一个价格特征，有一个方法GetPrice可以读取到价格，并且根
    //据距离distance计算价格price（1元/公里）
    //0~100公里不打折
    //101～200公里大9.5折
    //201～300公里打9折
    //300公里以上打8折
    //有一个显示方法，可以显示这张票的信息。
    //例如：100公里100块钱
    class Ticket
    {
        public float distance;
        public float price;
        public float money;

        public Ticket()
        {
            distance = 0;
            price = 1;
        }

        public Ticket(float distance):this()
        {
            this.distance = distance;
            money = GetPrice();
        }

        private float GetPrice()
        {
            if (distance < 0)
            {
                Console.WriteLine("距离不为负数");
            }
            if (distance >= 0 && distance <= 100)
            {
                money = price * distance;
            }
            else if (distance >= 101 && distance <= 200)
            {
                money = price * distance * 0.95f;
            }
            else if (distance >= 201 && distance <= 300)
            {
                money = price * distance * 0.9f;
            }
            else
            {
                money = price * distance * 0.8f;
            }
            return money;
        }

        //public float GetPrice(Ticket t)
        //{
        //    if (distance < 0)
        //    {
        //        Console.WriteLine("距离不为负数");
        //    }
        //    if(t.distance >= 0 && t.distance <= 100)
        //    {
        //        t.money = t.price * t.distance;
        //    }
        //    else if(t.distance >= 101 && t.distance <= 200)
        //    {
        //        t.money = t.price * t.distance * 0.95f;
        //    }
        //    else if(t.distance >= 201 && t.distance <= 300)
        //    {
        //        t.money = t.price * t.distance * 0.9f;
        //    }
        //    else
        //    {
        //        t.money = t.price * t.distance * 0.8f;
        //    }
        //    return t.money;
        //}

        public void PrintInfo()
        {
            Console.WriteLine("{0}公里{1}块钱",distance,money);
        }
    }
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("构造函数和析构函数练习题");
            Person p1 = new Person("秦靖杰",21);
            Person p2 = new Person();
            Console.WriteLine("姓名 {0} 年龄 {1}",p1.name,p1.age);
            Console.WriteLine("姓名 {0} 年龄 {1}", p2.name,p2.age);

            Class c1 = new Class();
            Class c2 = new Class("1908",61);
            Console.WriteLine("班级 {0} 学生数 {1}", c1.name ,c1.stunum);
            Console.WriteLine("班级 {0} 学生数 {1}", c2.name ,c2.stunum);

            Ticket t = new Ticket(500);
            t.PrintInfo();
        }
    }
}
