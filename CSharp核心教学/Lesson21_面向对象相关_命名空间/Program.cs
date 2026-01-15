using System;
//引用命名空间
using MyGame;
using MyGame2;
using MyGame.UI;

#region 知识点一 命名空间基本概念
//概念
//命名空间是用来组织和重用代码的
//作用
//就像是一个工具包,类就像是一件一件的工具,都是申明在命名空间中的
#endregion

#region 知识点二 命名空间的使用
//基本语法
//namespace 命名空间名
//{
//  类
//  类
//}
namespace MyGame
{
    class GameObject
    {

    }
}

namespace MyGame
{
    class Player : GameObject
    {

    }
}
#endregion

#region 知识点四 不同命名空间中允许有同名类

namespace MyGame2
{
    //不同命名空间中允许有同名类
    class GameObject
    {

    }
}

#endregion

#region 知识点五 命名空间可以包裹命名空间
namespace MyGame
{
    namespace UI
    {
        class Image
        {

        }
    }

    namespace Game
    {
        class Image
        {

        }
    }
}
#endregion

#region 知识点六 关于修饰类的访问修饰符
//public   — 命名空间中的类 默认为public
//internal — 只能在程序集中使用
//abstract — 抽象类
//sealed   — 密封类
//partial  — 分部类
#endregion

namespace Lesson21_面向对象相关_命名空间
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("命名空间");
            #region 知识点三 不同命名空间中相互使用 需要引用命名空间或指明出处
            //第一种方法 在最外面引用命名空间 如果出现了不同命名空间但是有同名类就用另外一个方法
            //GameObject g = new GameObject();
            Image img = new Image();

            //第二种方法 命名空间名.类名
            MyGame.GameObject g2 = new MyGame.GameObject();

            MyGame.UI.Image image = new MyGame.UI.Image();
            MyGame.Game.Image image2 = new MyGame.Game.Image();
            #endregion
        }
    }
    //总结
    //1.命名空间是个工具包 用来管理类的
    //2.不同命名空间中 可以有同名类
    //3.不同命名空间中相互使用 需要using引用命名空间 或者 指明出处
    //4.命名空间可以包裹命名空间
}