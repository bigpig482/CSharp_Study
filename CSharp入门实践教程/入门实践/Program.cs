using System;
using System.Security.Cryptography.X509Certificates;

namespace 入门实践
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1 控制台基础设置
            //隐藏光标
            Console.CursorVisible = false;
            //通过两个变量来设置窗口的大小
            int w = 50;
            int h = 30;
            //设置窗口大小
            Console.SetWindowSize(w,h);
            Console.SetBufferSize(w,h);
            //颜色设置
            //Console.BackgroundColor = ConsoleColor.White;

            #endregion

            #region 2 多个场景
            //当前场景所在的编号
            int nowScenceId = 1;
            //char input;//输入
            //int nowSelIndex = 0;//当前选择的编号
            string gameOverInfo = "";
            while (true)
            {
                switch (nowScenceId)
                {
                    //开始场景
                    case 1:
                        Console.Clear();
                        #region 3 开始场景逻辑

                        //标题
                        Console.SetCursorPosition(w / 2 - 7, 8);
                        Console.Write("秦靖杰营救公主");

                        int nowSelIndex = 0;//当前选择的编号

                        while (true)
                        {
                            //是否退出循环
                            bool isQuitWhile = false;

                            //显示 内容
                            //先设置光标位置 再显示内容
                            Console.SetCursorPosition(w / 2 - 4, 13);
                            Console.ForegroundColor = nowSelIndex == 0 ? ConsoleColor.Red : ConsoleColor.White;
                            Console.Write("开始游戏");

                            Console.SetCursorPosition(w / 2 - 4, 15);
                            Console.ForegroundColor = nowSelIndex == 1 ? ConsoleColor.Red : ConsoleColor.White;
                            Console.Write("退出游戏");

                            //检测 输入
                            char input = Console.ReadKey(true).KeyChar;
                            switch (input)
                            {
                                case 'W':
                                case 'w':
                                    --nowSelIndex;
                                    if (nowSelIndex < 0)
                                    {
                                        nowSelIndex = 0;
                                    }
                                    break;

                                case 'S':
                                case 's':
                                    ++nowSelIndex;
                                    if (nowSelIndex > 1)
                                    {
                                        nowSelIndex = 1;
                                    }
                                    break;

                                case 'J':
                                case 'j':
                                    if (nowSelIndex == 0)
                                    {
                                        //改变当前选择的场景ID
                                        nowScenceId = 2;
                                        //要退出当前的while循环
                                        isQuitWhile = true;
                                    }
                                    else
                                    {
                                        //关闭控制台
                                        Environment.Exit(0);
                                    }
                                    break;
                            }
                            if (isQuitWhile == true)
                            {
                                break;
                            }
                        }
                        #endregion
                        break;

                    //游戏场景
                    case 2:
                        Console.Clear();
                        #region 4 不变的红墙
                        //设置墙的颜色
                        Console.ForegroundColor = ConsoleColor.Red;
                        //画墙
                        for(int i = 0;i < w ;i+=2)
                        {
                            //上方墙
                            Console.SetCursorPosition(i, 0);
                            Console.Write("■");

                            //下方墙
                            Console.SetCursorPosition(i, h - 1);
                            Console.Write("■");

                            //中间墙
                            Console.SetCursorPosition(i, h - 6);
                            Console.Write("■");
                        }
                        for (int i = 0; i < h; i++)
                        {
                            //左边的墙
                            Console.SetCursorPosition(0,i);
                            Console.Write("■");
                            //右边的墙
                            Console.SetCursorPosition(w - 2, i);
                            Console.Write("■");
                        }

                        #endregion

                        #region 5 boss属性相关
                        int bossX = 24;
                        int bossY = 15;
                        int bossAtkmin = 7;
                        int bossAtkmax = 13;
                        int bossHp = 100;
                        string bossIcon = "■";
                        //申明一个颜色变量
                        ConsoleColor bossColor = ConsoleColor.Green;
                        #endregion

                        #region 6 玩家属性相关
                        int playerX = 4;
                        int playerY = 5;
                        int playerAtkmin = 8;
                        int playerAtkmax = 12;
                        int playerHp = 100;
                        string playerIcon = "●";
                        ConsoleColor playerColor = ConsoleColor.Yellow;
                        char playerInput;//玩家输入内容
                        #endregion

                        #region 7 玩家战斗相关
                        bool isFight = false;//战斗状态
                        #endregion

                        #region 8 公主相关
                        int princessX = 24;
                        int princessY = 5;
                        string princessIcon = "★";
                        ConsoleColor princesscolor = ConsoleColor.Blue;
                        #endregion

                        #region 9 结束逻辑相关
                        bool isOver = false;//从while内部循环中的switch 改变标识 用来跳出外层的while循环
                        #endregion

                        //游戏场景的死循环 检测玩家输入
                        while (true)
                        {
                            #region 5 boss属性相关
                            if (bossHp > 0)
                            {
                                //绘制boss图标
                                Console.SetCursorPosition(bossX, bossY);
                                Console.ForegroundColor = bossColor;
                                Console.Write(bossIcon);
                            }
                            #endregion

                            #region 8 公主相关
                            else
                            {
                                Console.SetCursorPosition(princessX, princessY);
                                Console.ForegroundColor = princesscolor;
                                Console.Write(princessIcon);
                            }
                            #endregion

                            if (playerHp > 0)
                            {
                                //绘制玩家图标
                                Console.SetCursorPosition(playerX, playerY);
                                Console.ForegroundColor = playerColor;
                                Console.Write(playerIcon);
                            }

                            playerInput = Console.ReadKey(true).KeyChar;

                            //战斗状态处理什么逻辑
                            if (isFight)
                            {
                                #region 7 玩家战斗相关
                                //在这判断 玩家或怪物死亡后的流程
                                if (playerHp <= 0)
                                {
                                    //游戏结束
                                    nowScenceId = 3;
                                    gameOverInfo = "游戏失败";
                                    break;
                                }
                                else if (bossHp <= 0)
                                {
                                    //去营救公主
                                    //boss擦除
                                    Console.SetCursorPosition(bossX, bossY);
                                    Console.Write("  ");
                                    isFight = false;
                                }
                                else
                                {
                                    //战斗状态做什么
                                    //只按j键
                                    if (playerInput == 'J' || playerInput == 'j')
                                    {
                                        //玩家打怪物
                                        Random r = new Random();
                                        //获得随机攻击力
                                        int atk = r.Next(playerAtkmin, playerAtkmax);
                                        //血量减少
                                        bossHp -= atk;
                                        //打印信息
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        //先擦除这一行 上一次显示的内容
                                        Console.SetCursorPosition(2, h - 4);
                                        Console.Write("                                             ");
                                        //再来写新的信息
                                        Console.SetCursorPosition(2, h - 4);
                                        Console.Write("你对BOSS造成了{0}点伤害，BOSS的剩余血量为{1}", atk, bossHp);

                                        //怪物打玩家
                                        if (bossHp > 0)
                                        {
                                            atk = r.Next(bossAtkmin, bossAtkmax);
                                            playerHp -= atk;

                                            Console.ForegroundColor = ConsoleColor.Red;
                                            //先擦除这一行 上一次显示的内容
                                            Console.SetCursorPosition(2, h - 3);
                                            Console.Write("                                             ");

                                            //Boss把玩家打死了
                                            if (playerHp <= 0)
                                            {
                                                Console.SetCursorPosition(2, h - 3);
                                                Console.Write("很遗憾，你未能通过boss的试炼，战败了");
                                            }
                                            else
                                            {
                                                Console.SetCursorPosition(2, h - 3);
                                                Console.Write("BOSS对你造成了{0}点伤害，你的剩余血量为{1}", atk, playerHp);
                                            }
                                        }
                                        else
                                        {
                                            //擦除之前的战斗信息
                                            Console.SetCursorPosition(2, h - 5);
                                            Console.Write("                                             ");
                                            Console.SetCursorPosition(2, h - 4);
                                            Console.Write("                                             ");
                                            Console.SetCursorPosition(2, h - 3);
                                            Console.Write("                                             ");

                                            //显示胜利信息
                                            Console.SetCursorPosition(2, h - 5);
                                            Console.Write("你战胜了Boss，快去营救公主");
                                            Console.SetCursorPosition(2, h - 4);
                                            Console.Write("前往公主身边，按J键继续");
                                        }
                                    }
                                }
                                #endregion
                            }
                            //非战斗状态处理什么逻辑
                            else
                            {
                                #region 6 玩家移动相关
                                //擦除
                                Console.SetCursorPosition(playerX, playerY);
                                Console.Write("  ");
                                //改变位置
                                switch (playerInput)
                                {
                                    case 'W':
                                    case 'w':
                                        playerY--;
                                        if (playerY < 1)
                                        {
                                            playerY = 1;
                                        }
                                        else if (playerX == bossX && playerY == bossY && bossHp > 0)
                                        {
                                            playerY++;
                                        }
                                        else if(playerX == princessX && playerY == princessY && bossHp <= 0)
                                        {
                                            playerY++;
                                        }
                                        break;
                                    case 'A':
                                    case 'a':
                                        playerX -= 2;
                                        if (playerX < 2)
                                        {
                                            playerX = 2;
                                        }
                                        else if (playerX == bossX && playerY == bossY && bossHp > 0)
                                        {
                                            playerX += 2;
                                        }
                                        else if (playerX == princessX && playerY == princessY && bossHp <= 0)
                                        {
                                            playerX += 2;
                                        }
                                        break;
                                    case 'S':
                                    case 's':
                                        playerY++;
                                        if (playerY > h - 7)
                                        {
                                            playerY = h - 7;
                                        }
                                        else if (playerX == bossX && playerY == bossY && bossHp > 0)
                                        {
                                            playerY--;
                                        }
                                        else if (playerX == princessX && playerY == princessY && bossHp <= 0)
                                        {
                                            playerY--;
                                        }
                                        break;
                                    case 'D':
                                    case 'd':
                                        playerX += 2;
                                        if (playerX > w - 4)
                                        {
                                            playerX = w - 4;
                                        }
                                        else if (playerX == bossX && playerY == bossY && bossHp > 0)
                                        {
                                            playerX -= 2;
                                        }
                                        else if (playerX == princessX && playerY == princessY && bossHp <= 0)
                                        {
                                            playerX -= 2;
                                        }
                                        break;
                                    case 'J':
                                    case 'j':
                                        //玩家不能再移动
                                        //下方显示信息
                                        //开始战斗
                                        if ((playerX == bossX && playerY == bossY - 1 ||
                                           playerX == bossX && playerY == bossY + 1 ||
                                           playerX == bossX - 2 && playerY == bossY ||
                                           playerX == bossX + 2 && playerY == bossY) && bossHp > 0)
                                        {
                                            isFight = true;
                                            //可以开始战斗
                                            Console.SetCursorPosition(2, h - 5);
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.Write("开始和Boss战斗了，按J键继续");
                                            Console.SetCursorPosition(2, h - 4);
                                            Console.Write("玩家当前血量为{0}", playerHp);
                                            Console.SetCursorPosition(2, h - 3);
                                            Console.Write("BOSS当前血量为{0}", bossHp);
                                        }
                                        //
                                        else if((playerX == princessX && playerY == princessY - 1 ||
                                           playerX == princessX && playerY == princessY + 1 ||
                                           playerX == princessX - 2 && playerY == princessY ||
                                           playerX == princessX + 2 && playerY == princessY) && bossHp <= 0)
                                        {
                                            //改变场景ID
                                            nowScenceId = 3;
                                            gameOverInfo = "游戏通过";
                                            //跳出 游戏界面while循环 回到主循环
                                            isOver = true;
                                        }
                                        break;
                                }

                                #endregion
                            }
                            //外层while循环逻辑
                            if(isOver)
                            {
                                break;
                            }
                        }
                        break;

                    //结束场景
                    case 3:
                        Console.Clear();

                        #region 9 结束逻辑代码
                        //标题显示
                        Console.SetCursorPosition(w / 2 - 4, 5);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("GameOver");
                        //可变内容显示
                        Console.SetCursorPosition(w / 2 - 4, 6);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(gameOverInfo);

                        int nowSelEndIndex = 0;
                        while (true)
                        {
                            bool isQuitEnd = false;

                            Console.SetCursorPosition(w / 2 - 6, 9);
                            Console.ForegroundColor = nowSelEndIndex == 0 ? ConsoleColor.Red : ConsoleColor.White;
                            Console.Write("回到开始界面");

                            Console.SetCursorPosition(w / 2 - 4, 11);
                            Console.ForegroundColor = nowSelEndIndex == 1 ? ConsoleColor.Red : ConsoleColor.White;
                            Console.Write("退出游戏");

                            char input = Console.ReadKey(true).KeyChar;

                            switch (input)
                            {
                                case 'W':
                                case 'w':
                                    --nowSelEndIndex;
                                    if (nowSelEndIndex < 0)
                                    {
                                        nowSelEndIndex = 0;
                                    }
                                    break;
                                case 'S':
                                case 's':
                                    ++nowSelEndIndex;
                                    if (nowSelEndIndex > 1)
                                    {
                                        nowSelEndIndex = 1;
                                    }
                                    break;
                                case 'J':
                                case 'j':
                                    if (nowSelEndIndex == 0)
                                    {
                                        nowScenceId = 1;
                                        isQuitEnd = true;
                                    }
                                    else
                                    {
                                        Environment.Exit(0);
                                    }
                                    break;
                            }
                            if (isQuitEnd)
                            {
                                break;
                            }
                        }
                        #endregion

                        break;
                }
            }

            #endregion
        }
    }
}
