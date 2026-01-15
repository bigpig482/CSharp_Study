using System;

namespace Lesson2_练习题
{
    #region 练习题1
    //3P是什么？
    //public 公共的 内外
    //private 私有的 内
    //protected 保护的 内和子类
    #endregion

    #region 练习题2
    //定义一个人类，有姓名，身高，年龄，家庭住址等特征
    //用人创建若干个对象
    class Person 
    { 
        public string name;
        public float heigth;
        public int age;
        public string address;
    }
    #endregion

    #region 练习题3
    //定义一个学生类，有姓名，学号，年龄，同桌等特征，有学习方法。
    //用学生类创建若干个学生
    class Student
    {
        public string name;
        public int index;
        public int age;
        public Student deskmate;

        public void Study()
        {
            Console.WriteLine("学习方法");
        }
    }
    #endregion

    #region 练习题4
    //定义一个班级类，有专业名称，教师容量，学生等
    //创建一个班级对象
    class Class
    {
        public string majorname;
        public int teachernum;
        public Student[] students;
    }
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("成员变量和访问修饰符练习题");
            #region 练习题2
            //定义一个人类，有姓名，身高，年龄，家庭住址等特征
            //用人创建若干个对象
            Person p1 = new Person();
            p1.name = "秦靖杰";
            p1.heigth = 185.1f;
            p1.age = 22;
            p1.address = "地球";

            Person p2 = new Person();
            p2.name = "王俊豪";
            p2.heigth = 181.1f;
            p2.age = 21;
            p2.address = "地球";
            #endregion

            #region 练习题3
            Student s1 = new Student();
            s1.name = "秦靖杰";
            s1.age = 22;
            s1.index = 1;

            Student s2 = new Student();
            s2.name = "王俊豪";
            s2.index = 2;
            s2.age = 21;

            s1.deskmate = s2;
            s2.deskmate = s1;
            #endregion

            #region 练习题4
            Class c1 = new Class();
            c1.majorname = "Unity";
            c1.teachernum = 10;
            c1.students = new Student[] { s1, s2 };
            #endregion

            #region 练习题5
            //Person p = new Person():
            //p.age=10;
            //Person p2 = new Person():
            //p2.age. = 20;
            //请问p.age为多少?

            //答:10
            #endregion

            #region 练习题6
            //Person p = new Person():
            //p.age =10;
            //Person p2 = p;
            //p2.age= 20;
            //请问p.age为多少?

            //答:是20
            #endregion

            #region 练习题7
            //Student s = new Student():
            //s.age = 10;
            //int age = s.age;
            //age = 20;
            //请问s.age为多少？

            //答:是10
            #endregion

            #region 练习题8
            //Student s = new Student():
            //s.deskmate = new Student():
            //s.deskmate.age = 10;
            //Sudent s2 = s.deskmate;
            //s2.age = 20;
            //请问s.deskmate.age为多少?

            //答:是20
            #endregion
        }
    }
}