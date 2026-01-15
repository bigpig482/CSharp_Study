using System;
using System.Collections.Generic;

namespace Lesson23_特殊语法
{
    class Person
    {
        private int money;
        public bool sex;

        public string Name 
        {
            get => "nihao"; 
            set => sex =true; 
        }

        public int Age { get; set; }

        public Person()
        {

        }

        public Person(int money)
        {
            this.money = money;
        }

        //单句代码的省略写法
        public int Add(int x, int y) => x + y;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("特殊语法");

            #region 知识点一 var隐式类型
            //var是一种特殊的变量类型
            //它可以用来表示任意类型的变量
            //注意:
            //1.var不能作为类的成员 只能用于临时变量申明
            //  也就是 一般写在函数语句块中
            //2.var必须初始化

            var i = 5;
            var s = "123";
            var array = new int[] { 1, 2, 3, 4 };
            var list = new List<int>();
            //初始化后是什么变量类型就是什么变量类型
            #endregion

            #region 知识点二 设置对象初始值
            //申明对象时
            //可以通过直接写大括号的形式初始化公共成员变量和属性

            Person p = new Person() { sex = true, Name = "老王", Age = 18 };
            Person p2 = new Person(100) { Age = 18 };
            //括号可以省略不写(有无参构造时) 大括号里的参数可以不写全
            #endregion

            #region 知识点三 设置集合初始值
            //申明集合对象时
            //也可以通过大括号 直接初始化内部属性
            int[] array2 = new int[] { 1, 2, 3, 4, 5 };

            List<int> list2 = new List<int>() { 1, 2, 3, 4, 5 };
            List<Person> people = new List<Person>()
            {
                p, p2,
                new Person(100),
                new Person(){ Age = 18}
            };
            Dictionary<int, string> dic = new Dictionary<int, string>()
            {
                { 1,"123"},
                { 2,"456"}
            };
            #endregion

            #region 知识点四 匿名类型
            //var 变量可以申明为自定义的匿名类型
            var v = new { age = 10, money = 11, name = "小明" };
            Console.WriteLine(v.age);
            Console.WriteLine(v.money);
            #endregion

            #region 知识点五 可空类型
            //1.值类型是不能赋值为 空的
            //int c = null;

            //2.申明时 在值类型后面加? 可以赋值为空
            int? c = null;

            //3.判断是否为空
            if(c.HasValue)
            {
                Console.WriteLine(c);
                Console.WriteLine(c.Value);
            }
            //4.安全获取可空类型值
            int? value = null;
            // 4-1 如果为空 默认值返回值类型的默认值
            Console.WriteLine(value.GetValueOrDefault());
            // 4-2 也可以指定一个默认值
            Console.WriteLine(value.GetValueOrDefault(100));
            Console.WriteLine(value);

            object o = null;
            if(o != null)
            {
                o.ToString();
            }
            //相当于是一种语法糖 能够帮助我们自动去判断o是否为空
            //如果是null就不会执行tostring也不会报错
            o?.ToString();

            int[] arrInt = null;
            Console.WriteLine(arrInt?[0]);

            Action action = null;
            action?.Invoke();
            #endregion

            #region 知识点六 空合并操作符
            //空合并操作符??
            //左边值 ?? 右边值
            //如果左边值为null 就返回右边值 否则返回左边值
            //只要是可以为null的类型都能用

            int? intV = null;
            int intI = intV == null ? 100 : intV.Value;
            intI = intV ?? 100;
            Console.WriteLine(intI);

            string str = null;
            str = str ?? "你好";
            Console.WriteLine(str);
            #endregion

            #region 知识点七 内插字符串
            //关键符号:$
            //用$来构造字符串，让字符串中可以拼接变量
            string name = "奶龙";
            Console.WriteLine($"好好学习,{name}");
            #endregion

            #region 知识点八 单句逻辑简略写法
            //当循环或者if语句中只有 依据代码时 大括号可以省略
            if (true)
                Console.WriteLine("123");
            for (int j = 0; j < 10; j++)
                Console.WriteLine(i);

            #endregion
        }
    }
}
