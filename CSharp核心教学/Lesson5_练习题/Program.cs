using System;

namespace Lesson5_练习题
{
    #region 练习题
    //定义一个学生类，有五种属性，分别为姓名、性别、年龄、CSharp成
    //绩、Unity成绩
    //有两个方法：
    //一个打招呼：介绍自己交XX，今年几岁了。是男同学还是女同学
    //计算自己总分数和平均分并显示的方法
    //使用属性完成：年龄必须是0 ~150之间，成绩必须是0 ~100
    //性别只能是男或女
    //实例化两个对象并测试
    enum E_SexType
    {
        Man,
        Woman,
    }
    class Student
    {
        public string name;
        public bool sex;
        private int age;
        private int cscore;
        private int uscore;

        public Student()
        {
            name = "秦靖杰";
            sex = true;
            age = 21;
            cscore = 60;
            uscore = 70;
            GetSumAvg();
        }

        public Student(string name)
        {
            this.name = name;
        }

        public int Age
        {
            get
            {
                if (age > 0 && age < 150)
                {
                    return age;
                }
                else
                {
                    Console.WriteLine("输入的年龄不在范围内");
                    return 0;
                }
            }
            set
            {
                if(value > 0 && value < 150)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("输入的年龄不在范围内");
                }
            }
        }

        public int CScore
        { 
            get
            {
                return cscore;
            }
            set
            {
                if(value >= 0 && value <= 100)
                {
                    cscore = value;
                }
            }
        }

        public int UScore
        {
            get
            {
                return uscore;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    uscore = value;
                }
            }
        }

        public string Sex
        {
            get
            {
                if(sex)
                {
                    return "男";
                }
                else
                {
                    return "女";
                }
            }
        }

        public void Speak()
        {
            Console.WriteLine("我叫{0},今年{1}岁了。是{2}同学",name,age,Sex);
        }

        private float[] GetSumAvg()
        {
            float sum = cscore + uscore;
            float avg = sum / 2f;
            return new float [] { sum, avg };
        }

        public void PrintScore()
        {
            float[] arr = GetSumAvg();
            Console.WriteLine("总分{0},平均分{1}", arr[0], arr[1]);
        }
    }
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("成员属性练习题");
            Student s1 = new Student();
            Student s2 = new Student("王俊豪");
            s2.Age = 18;
            s2.CScore = 45;
            s2.UScore = 95;
            s2.sex = false;

            s1.Speak();
            s1.PrintScore();

            s2.Speak();
            s2.PrintScore();
        }
    }
}
