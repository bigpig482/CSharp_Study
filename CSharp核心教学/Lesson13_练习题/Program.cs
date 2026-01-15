using System;

namespace Lesson13_练习题
{
    #region 练习题1
    //is和as的区别是什么
    //is 用于判断 是为真 不是为假
    //as 用于转换 成功为对象 失败为null
    #endregion

    #region 练习题2
    //写一个Monster类，它派生出Boss和Goblin两个类，Boss有技能；小怪
    //有攻击；随机生成10个怪，装载到数组中，遍历这个数组，调用他们的
    //攻击方法，如果是boss就释放技能
    class Monster
    {

    }
    class Boss:Monster
    {
        public void Skill()
        {
            Console.WriteLine("Boss释放技能");
        }
    }
    class Goblin:Monster
    {
        public void Atk()
        {
            Console.WriteLine("小怪攻击");
        }
    }
    #endregion

    #region 练习题3
    //FPS游戏模拟
    //写一个玩家类，玩家可以拥有各种武器
    //现在有四种武器，冲锋枪，散弹枪，手枪，匕首
    //玩家默认拥有匕首
    //请在玩家类中写一个方法，可以拾取不同的武器替换自己拥有的枪械
    static class Tools
    {

    }
    class Player
    {
        private Weapon nowWeapon;
        public Player()
        {
            nowWeapon = new Dagger();
        }
        public void Pick(Weapon weapon)
        {
            nowWeapon = weapon;
        }
    }

    class Weapon : Player
    {

    }

    class Dagger : Weapon
    {

    }

    class SubmachineGun : Weapon
    {

    }

    class Shotgun : Weapon
    {

    }

    class Pistol : Weapon
    {

    }
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("里氏替换原则");

            #region 练习题2
            Random r = new Random();   
            Monster[] monsters = new Monster[10];
            for (int i = 0; i < monsters.Length; i++)
            {
                int mtype = r.Next(0, 101);
                if (mtype <70)
                {
                    monsters[i] = new Goblin();
                }
                else
                {
                    monsters[i] = new Boss();
                }
                if (monsters[i] is Boss)
                {
                    (monsters[i] as Boss).Skill();
                }
                else
                {
                    (monsters[i] as Goblin).Atk();
                }
            }
            #endregion

            #region 练习题3
            Player p = new Player();
            SubmachineGun gun = new SubmachineGun();
            p.Pick(gun);
            #endregion
        }
    }
}
