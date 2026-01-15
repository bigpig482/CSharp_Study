using System;
using System.Reflection;

namespace Lesson20_练习题
{
    #region 练习题
    //新建一个类库工程
    //有一个Player类，有姓名，血量，攻击力，防御力，位置等信息
    //有一个无参构造函数
    //再新建一个控制台工程
    //通过反射的形式使用类库工程生成的dll程序集
    //实例化一个Player对象
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("反射练习题");
            Assembly asmpPlayer = Assembly.LoadFrom("D:\\unity study\\CSharp进阶教程\\类库测试\\bin\\Debug\\net8.0\\类库测试");
            Type player = asmpPlayer.GetType("类库测试.Player");
            object playerObj = Activator.CreateInstance(player);
            Console.WriteLine(playerObj);
        }
    }
}
