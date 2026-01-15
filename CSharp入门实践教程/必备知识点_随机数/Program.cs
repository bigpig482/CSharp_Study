using System;

namespace 必备知识点_随机数
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("随机数");

            #region 知识点一 产生随机数对象
            //固定写法
            //Random 随机数变量名 = new Random();
            //Random r = new Random();
            #endregion

            #region 知识点二 生成随机数
            //int i = r.Next();//生成一个非负数的随机数
            //Console.WriteLine(i);

            //i = r.Next(100);//生成一个0到99的随机数 左边始终是0 左包含 右边是100 右不包含
            //Console.WriteLine(i);

            //i = r.Next(5,100);//生成一个5到100的随机数
            //Console.WriteLine(i);
            #endregion

            #region 练习题
            //唐老师打小怪兽
            //唐老师攻击力为8到12之间的一个值
            //小怪兽防御为10，血量为20
            //在控制台中通过打印信息表现唐老师打小怪兽的过程
            //描述小怪兽的掉血情况
            //伤害计算公式:攻击力小于防御力时，减血为0，否则减血攻击力和防御力的差值

            Random attack = new Random();
            int defen = 10, health = 20;
            int att;
            while (health > 0)
            {
                att = attack.Next(8,13);
                if(att <= defen)
                {
                    Console.WriteLine("你没有对小怪兽造成实质伤害，你的攻击力是{0}，小怪兽的剩余血量为{1}",att,health);
                }
                else
                {
                    health = health - (att - defen);
                    Console.WriteLine("你对小怪兽造成了{0}点伤害，小怪兽的剩余血量为{1}",att - defen,health - (att - defen));
                }

                Console.WriteLine("请按任意键继续");
                Console.ReadKey(true);
                Console.Clear();
            }
            Console.WriteLine("小怪兽死亡");

            #endregion
        }
    }
}
