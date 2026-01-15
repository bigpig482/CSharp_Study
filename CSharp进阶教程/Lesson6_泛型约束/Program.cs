using System;

namespace Lesson6_泛型约束
{
    #region 知识回顾
    //泛型类
    //泛型函数
    //泛型接口
    #endregion

    #region 知识点一 什么是泛型约束
    //让泛型的类型有一定的限制
    //关键字:where
    //泛型约束一共有6种
    //1.值类型                              where 泛型字母:struct
    //2.引用类型                            where 泛型字母:class
    //3.存在无参公共构造函数                where 泛型字母:new()
    //4.某个类本身或者派生类                where 泛型字母:类名
    //5.某个接口的派生类                    where 泛型字母:接口名
    //6.另一个泛型类型本身或者派生类型      where 泛型字母:另一个泛型字母

    //where 泛型字母:(约束的类型)
    #endregion

    #region 知识点二 各泛型约束讲解

    #region 值类型约束
    class Test1<T> where T : struct
    {
        public T value;
        public void TestFun<K>(K k)where K : struct
        {

        }
    }
    #endregion

    #region 引用类型类型约束
    class Test2<T> where T : class
    {
        public T value;
        public void TestFun<K>(K k) where K : class
        {

        }
    }
    #endregion

    #region 公共无参构造约束
    //不能是抽象类 必须是公共的 有无参构造函数
    class Test3<T> where T : new()
    {
        public T value;
        public void TestFun<K>(K k) where K : new()
        {

        }
    }

    class Test1
    {
        
    }

    class Test2
    {
        public Test2(int a)
        {
            
        }
    }
    #endregion

    #region 类约束
    class Test4<T> where T : Test1
    {
        public T value;
        public void TestFun<K>(K k) where K : Test1
        {

        }
    }

    class Test3 : Test1
    {

    }
    #endregion

    #region 接口约束
    class Test5<T> where T : IFly
    {
        public T value;
        public void TestFun<K>(K k) where K : IFly
        {

        }
    }

    interface IFly
    {

    }

    interface IMove : IFly
    {
        
    }
    class Test4 : IFly
    {

    }
    #endregion

    #region 另一个泛型约束
    class Test6<T,U> where T : U
    {
        public T value;
        public void TestFun<K,V>(K k) where K : V
        {

        }
    }
    #endregion

    #endregion

    #region 知识点三 约束的组合使用
    class Test7<T> where T : class,new()
    {
        
    }
    #endregion

    #region 知识点四 多个泛型有约束
    class Test8<T,K> where T : class,new() where K : struct
    {

    }
    #endregion

    #region 总结
    //泛型约束:让类型有一定限制
    //class
    //struct
    //new()
    //类名
    //接口名
    //另一个泛型字母

    //注意:
    //1.可以组合使用
    //2.多个泛型约束 用where连接即可
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("泛型约束");
            Test1<int> test = new Test1<int>();
            test.TestFun<int>(10);

            Test2<Random> test2 = new Test2<Random>();
            test2.TestFun<object>(new object());

            Test3<Test1> test3 = new Test3<Test1>();
            //Test3<Test2> test4 = new Test3<Test2>();

            Test4<Test3> test4 = new Test4<Test3>();
            Test4<Test1> test5 = new Test4<Test1>();

            Test5<IFly> test6 = new Test5<IFly>();
            Test5<IMove> test7 = new Test5<IMove>();
            Test5<Test4> test8 = new Test5<Test4>();

            Test6<Test4, IFly> test9 = new Test6<Test4, IFly>();
        }
    }
}
