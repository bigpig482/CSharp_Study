using System;

namespace Lesson7_练习题
{
    #region 练习题1
    //请描述List和ArrayList的区别

    //List内部封装的是一个泛型数组
    //ArrayList内部封装的是一个object数组
    #endregion

    #region 练习题2
    //建立一个整形List，为它添加10~1
    //删除List中第五个元素
    //遍历剩余元素并打印
    #endregion

    #region 练习题3
    //一个Monster基类，Boss和Gablin类继承它。
    //在怪物类的构造函数中，将其存储到一个怪物List中
    //遍历列表可以让Boss和Gablin对象产生不同攻击
    abstract class Monster
    {
        public static List<Monster> monsters = new List<Monster>();
        public Monster()
        {
            monsters.Add(this);
        }

        public abstract void Akt();
        
    }

    class Boss : Monster
    {
        public override void Akt()
        {
            Console.WriteLine("Boss攻击");
        }
    }

    class Goblin : Monster
    {
        public override void Akt()
        {
            Console.WriteLine("哥布林攻击");
        }
    }
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("List练习题");
            List<int> ints = new List<int>();
            ints.Add(10);
            ints.Add(9);
            ints.Add(8);
            ints.Add(7);
            ints.Add(6);
            ints.Add(5);
            ints.Add(4);
            ints.Add(3);
            ints.Add(2);
            ints.Add(1);

            ints.RemoveAt(4);

            for (int i = 0; i < ints.Count; i++)
            {
                Console.WriteLine(ints[i]);
            }

            Boss boss = new Boss();
            Goblin goblin = new Goblin();

            for (int i = 0;i < Monster.monsters.Count; i++)
            {
                Monster.monsters[i].Akt();
            }
        }
    }
}
