using System;

namespace Lesson22_练习题
{
    #region 练习题1
    //有一个玩家类，有姓名，血量，攻击力，防御力，闪避率等特征
    //请在控制台打印出“玩家XX，血量XX，攻击力XX，防御力XX”XX为具体内容
    class Player
    {
        public string name;
        public int hp;
        public int atk;
        public int dfs;
        //public float dodge;

        public Player()
        {
            name = "彬彬";
            hp = 100;
            atk = 10;
            dfs = 5;
        }

        public override string ToString()
        {
            return string.Format("玩家{0}，血量{1}，攻击力{2}，防御力{3}",name,hp,atk,dfs);
        }
    }
    #endregion

    #region 练习题2
    //一个Monster类的引用对象A，Monster类有攻击力、防御力、血量、
    //技能ID等属性。我想复制一个和A对象一模一样的B对象。并且改变了B
    //的属性，A不会受到影响。请问如何实现？
    class Monster
    {
        public Monster(string name,int hp,int atk,int def,int skillid)
        {
            Name = name;
            Hp = hp;
            Atk = atk;
            Def = def;
            SkillId = skillid;
        }
        public string Name { get; set; }
        public int Hp { get; set; }
        public int Atk { get; set; }
        public int Def { get; set; }
        public int SkillId { get; set; }

        public override string ToString()
        {
            return string.Format("姓名{0}，血量{1}，攻击力{2}，防御力{3}，技能ID{4}",Name,Hp,Atk,Def,SkillId);
        }

        public Monster Clone()
        {
            return MemberwiseClone() as Monster;
        }
    }
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("万物之父中的方法练习题");
            Player p = new Player();
            Console.WriteLine(p);

            Monster m = new Monster("秦靖杰",100,10,5,1);
            Monster m2 = m.Clone();
            m2.Atk = 12;
            m2.SkillId = 2;
            Console.WriteLine(m);
            Console.WriteLine(m2);
        }
    }
}
