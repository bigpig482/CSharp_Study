using System;
using System.Text;

namespace Lesson24_面向对象相关_StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("StringBuilder");

            #region 知识回顾
            //string是特殊的引用
            //每次重新赋值或者拼接时会分配新的内存空间
            //如果每一个字符串经常改变会非常浪费空间
            #endregion

            #region 知识点 StringBuilder
            //C#提供的一个用于处理字符串的公共类
            //主要解决的问题是：
            //修改字符串而不创建新的对象，需要频繁修改和拼接的字符串可以使用它，可以提示性能
            //使用前 需要引用命名空间

            #region 初始化 直接指明内容
            //StringBuilder("123456",100) 100代表容量
            StringBuilder str = new StringBuilder("123456");
            Console.WriteLine(str);
            #endregion

            #region 容量
            //StringBuilder存在一个容量的问题 每次往里面增加时 会自动扩容
            //获得容量 Capacity
            Console.WriteLine(str.Capacity);

            //获得字符长度
            Console.WriteLine(str.Length);
            #endregion

            #region 增删查改替换
            //增 Append()
            str.Append("78910");
            Console.WriteLine(str);
            Console.WriteLine(str.Capacity);
            Console.WriteLine(str.Length);

            //AppendFormat()
            str.AppendFormat("{0}{1}","11","121314");
            Console.WriteLine(str);
            Console.WriteLine(str.Capacity);
            Console.WriteLine(str.Length);

            //插入 Insert()
            str.Insert(0, "奶龙");
            Console.WriteLine(str);

            //删 Remove()
            str.Remove(0, 10);
            Console.WriteLine(str);

            //清空 Clear()
            //str.Clear();
            //Console.WriteLine(str);

            //查 
            Console.WriteLine(str[0]);

            //改
            str[0] = 'a';
            Console.WriteLine(str[0]);

            //替换 Replace
            str.Replace("11","贝利亚");
            Console.WriteLine(str);

            //重新赋值 StringBuilder
            str.Clear();
            str.Append("123456");
            Console.WriteLine(str);
            //判断StringBuilder是否和某一个字符串相等
            if(str.Equals("123456"))
            {
                Console.WriteLine("相等");
            }
            #endregion

            #endregion
        }
    }
}
