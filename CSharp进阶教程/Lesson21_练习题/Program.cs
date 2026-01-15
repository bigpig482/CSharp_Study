using System;
using System.Reflection;

namespace Lesson21_练习题
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("变量");
            #region 练习题
            //为反射练习题中的Player对象
            //随便为其中一个成员变量加一个自定义特性
            //同样实现反射练习题中的要求
            //但是当在设置加了自定义特性的成员变量时，在控制台中打印一句
            //非法操作，随意修改XXX成员

            Assembly asmpPlayer = Assembly.LoadFrom("D:\\unity study\\CSharp进阶教程\\类库测试\\bin\\Debug\\net8.0\\类库测试");
            Type player = asmpPlayer.GetType("类库测试.Player");
            object playerObj = Activator.CreateInstance(player);
            Console.WriteLine(playerObj);

            //首先要得到自定义特性的Type
            Type attribute = asmpPlayer.GetType("类库测试.MyCustomAttribute");
            //赋值名字
            FieldInfo fildStr = player.GetField("name");
            //得到的特性如果不为空 就证明有
            if(fildStr.GetCustomAttribute(attribute) != null)
            {
                Console.WriteLine("非法操作，随意修改name成员");
            }
            else
            {
                fildStr.SetValue(playerObj,"789456");
            }
            #endregion
        }
    }
}
