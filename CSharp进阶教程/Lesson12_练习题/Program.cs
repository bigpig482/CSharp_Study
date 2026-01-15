using System;

namespace Lesson12_练习题
{
    #region 练习题1
    //一家三口，妈妈做饭，爸爸妈妈和孩子都要吃饭
    //用委托模拟做饭—>开饭—>吃饭的过程
    abstract class Person
    {
        public abstract void Eat();
    }

    class Monther : Person
    {
        public Action beginEat;
        public override void Eat()
        {
            Console.WriteLine("妈妈吃饭");
        }

        public void DoFood()
        {
            Console.WriteLine("妈妈做饭");

            Console.WriteLine("妈妈做好饭了");

            beginEat();
        }
    }

    class Father : Person
    {
        public override void Eat()
        {
            Console.WriteLine("爸爸吃饭");
        }
    }

    class Son : Person
    {
        public override void Eat()
        {
            Console.WriteLine("儿子吃饭");
        }
    }
    #endregion

    #region 练习题2
    //怪物死亡后，玩家要加10块钱，界面要更新数据，成就要累加怪物击杀
    //数，请用委托来模拟实现这些功能，只用写核心逻辑表现这个过程，不
    //用写的太复杂
    class Monster
    {
        //当怪物死亡时 把自己作为参数传出去
        public Action<Monster> deadDoSomething;
        //怪物值多少钱
        public int money = 10;
        public void Dead()
        {
            Console.WriteLine("怪物死亡");
            if(deadDoSomething != null)
            {
                deadDoSomething(this);
            }
            //一般情况下 委托关联的函数 有加 就有减(或者直接清空)
            deadDoSomething = null;
        }
    }

    class Player
    {
        private int myMoney;
        public void MonsterDeadDoSomething(Monster m)
        {
            myMoney += m.money;
            Console.WriteLine("现在有{0}元钱",myMoney);
        }
    }

    class Pannel
    {
        private int nowShowMoney = 0;
        public void MonsterDeadDoSomething(Monster m)
        {
            nowShowMoney += m.money;
            Console.WriteLine("当前面版有{0}元钱", nowShowMoney);
        }
    }

    class CJ
    {
        private int nowKillMonster = 0;
        public void MonsterDeadDoSomething(Monster m)
        {
            nowKillMonster += 1;
            Console.WriteLine("当前击杀{0}个怪物", nowKillMonster);
        }
    }
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("委托练习题");

            #region 练习题1
            Monther m = new Monther();
            Father f = new Father();
            Son s = new Son();

            m.beginEat += f.Eat;
            m.beginEat += s.Eat;
            m.beginEat += m.Eat;

            m.DoFood();
            #endregion

            #region 练习题2
            Monster monster = new Monster();
            Player p = new Player();
            Pannel panel = new Pannel();
            CJ cJ = new CJ();

            monster.deadDoSomething += p.MonsterDeadDoSomething;
            monster.deadDoSomething += panel.MonsterDeadDoSomething;
            monster.deadDoSomething += cJ.MonsterDeadDoSomething;

            monster.Dead();
            #endregion
        }
    }
}