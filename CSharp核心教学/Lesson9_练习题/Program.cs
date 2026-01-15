using System;

namespace Lesson9_练习题
{
    #region 练习题1
    //为整形拓展一个求平方的方法
    static class Extra
    {
        public static int GetSquare2(this int i)
        {
            return i * i;
        }

        public static int Suicide(this Player p)
        {
            Console.WriteLine("玩家{0}自杀了",p.name);
            return p.hp = 0;
        }
    }
    #endregion

    #region 练习题2
    //写一个玩家类,包含姓名,血量,攻击力,防御力等特征
    //攻击,移动,受伤等方法
    //为该玩家类拓展一个自杀的方法
    class Player
    {
        public string name;
        public int hp;
        public int atk;
        public int def;
        public int pos;

        public void Atk(Player otherplayer)
        {
            Console.WriteLine("玩家造成了{0}点伤害",atk);
        }

        public void Run()
        {
            Console.WriteLine("玩家移动了{0}米",pos);
        }
        public void Pain(Player otherplayer)
        {
            int pain = otherplayer.atk - def;
            hp = hp - pain;
            Console.WriteLine("玩家受到了{0}点伤害,剩余血量为{1}", pain, hp);
        }
    }
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("拓展方法练习题");
            int i = 10;
            Console.WriteLine("拓展的方法算出来的平方是{0}",i.GetSquare2());
        }
    }
}
