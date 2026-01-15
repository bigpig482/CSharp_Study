using System;

namespace CSharp基础实践教学
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1 控制台初始化
            int w = 50;
            int h = 30;
            ConsoleInit(w,h);
            #endregion

            #region 2 场景选择相关
            //申明一个 表示场景标识的 变量
            E_SceneType nowSceneType = E_SceneType.Begin;
            while(true)
            {
                switch (nowSceneType)
                {
                    case E_SceneType.Begin:
                        //开始场景逻辑
                        Console.Clear();
                        BeginOrEndScene(w,h,ref nowSceneType);
                        break;
                    case E_SceneType.Game:
                        //游戏场景逻辑
                        Console.Clear();
                        //通过函数来处理游戏场景得内容逻辑
                        GameScene(w,h,ref nowSceneType);
                        break;
                    case E_SceneType.End:
                        //结束场景逻辑
                        Console.Clear();
                        BeginOrEndScene(w, h, ref nowSceneType);
                        break;
                }
            }
            #endregion
        }

        #region 1 控制台初始化
        static void ConsoleInit(int w,int h)
        {
            //基础设置
            //光标隐藏
            Console.CursorVisible = false;
            //舞台大小
            Console.SetWindowSize(w,h);
            Console.SetBufferSize(w,h);
        }
        #endregion

        #region 3 开始场景逻辑 + 9 结束场景逻辑
        static void BeginOrEndScene(int w,int h,ref E_SceneType nowSceneType)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(nowSceneType == E_SceneType.Begin ? w / 2 - 3 : w / 2 - 4, 8);
            Console.Write(nowSceneType == E_SceneType.Begin ? "飞行棋" : "游戏结束");
            //当前选项的编号
            int nowSelIndex = 0;

            bool isQuitBegin = false;
            //开始场景逻辑处理循环
            while (true)
            {
                Console.SetCursorPosition(nowSceneType == E_SceneType.Begin ? w / 2 - 4 : w / 2 - 5, 13);
                Console.ForegroundColor = nowSelIndex == 0 ? ConsoleColor.Red:ConsoleColor.White;
                Console.Write(nowSceneType == E_SceneType.Begin ? "开始游戏":"返回菜单");

                Console.SetCursorPosition(w / 2 - 4, 15);
                Console.ForegroundColor = nowSelIndex == 1 ? ConsoleColor.Red : ConsoleColor.White;
                Console.Write("退出游戏");

                isQuitBegin = false;
                //通过ReadKey可以得到一个输入的枚举类型
                switch(Console.ReadKey(true).Key)
                {
                    case ConsoleKey.W:
                        --nowSelIndex;
                        if(nowSelIndex < 0)
                        {
                            nowSelIndex = 0;
                        }
                        break;
                    case ConsoleKey.S:
                        ++nowSelIndex;
                        if(nowSelIndex > 1)
                        {
                            nowSelIndex = 1;
                        }
                        break;
                    case ConsoleKey.J:
                        if(nowSelIndex == 0)
                        {
                            //进入游戏场景
                            //1. 改变场景Id
                            nowSceneType = nowSceneType == E_SceneType.Begin ? E_SceneType.Game:E_SceneType.Begin;
                            //2. 退出当前循环
                            isQuitBegin = true;
                        }
                        else
                        {
                            //退出游戏
                            Environment.Exit(0);
                        }
                        break;
                }
                //跳出开始场景循环
                if (isQuitBegin)
                {
                    break;
                }
            }
        }
        #endregion

        #region 游戏场景逻辑
        static void GameScene(int w,int h,ref E_SceneType nowSceneTyp)
        {
            //绘制不变的基本信息
            DrawWall(w,h);
            //绘制地图
            //初始化一张地图
            Map map = new Map(14,3,80);
            map.Draw();
            //绘制玩家
            Player player = new Player(0,E_PlayerType.Player);
            Player computer = new Player(0,E_PlayerType.Computer);
            DrawPlayer(player,computer,map);

            bool isGameover = false;
            //游戏场景循环
            while(true)
            {
                //玩家扔色子的逻辑
                //检测输入
                Console.ReadKey(true);
                //扔色子的逻辑
                isGameover = RandomMove(w,h,ref player,ref computer,map);
                //绘制地图
                map.Draw();
                //绘制玩家
                DrawPlayer(player,computer,map);
                //判断是否要结束游戏
                if(isGameover)
                {
                    //卡住程序 让玩家按任意键
                    Console.ReadKey(true);
                    //改变场景ID
                    nowSceneTyp = E_SceneType.End;
                    //跳出循环
                    break;
                }

                //电脑扔色子的逻辑
                //检测输入
                Console.ReadKey(true);
                //扔色子的逻辑
                isGameover = RandomMove(w, h, ref computer, ref player, map);
                //绘制地图
                map.Draw();
                //绘制玩家
                DrawPlayer(player, computer, map);
                //判断是否要结束游戏
                if (isGameover)
                {
                    //卡住程序 让玩家按任意键
                    Console.ReadKey(true);
                    //改变场景ID
                    nowSceneTyp = E_SceneType.End;
                    //跳出循环
                    break;
                }
            }
        }
        #endregion

        #region 4 绘制不变内容(红墙 提示等)
        static void DrawWall(int w,int h)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            //画墙
            //横着的墙
            for(int i = 0;i < w;i += 2)
            {
                //最上方的墙
                Console.SetCursorPosition(i,0);
                Console.Write("■");
                //最下方的墙
                Console.SetCursorPosition(i, h - 1);
                Console.Write("■");

                //中间的墙
                Console.SetCursorPosition(i, h - 6);
                Console.Write("■");
                Console.SetCursorPosition(i, h - 11);
                Console.Write("■");
            }
            //竖着的墙
            for(int i = 0;i < h;i++)
            {
                //最右边
                Console.SetCursorPosition(0,i);
                Console.Write("■");
                //最左边
                Console.SetCursorPosition(w - 2, i);
                Console.Write("■");
            }

            //文字信息
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(2,h - 10);
            Console.Write("□:普通格子");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(2, h - 9);
            Console.Write("‖:暂停,一回合不动");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(26, h - 9);
            Console.Write("●:炸弹,倒退五格");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(2, h - 8);
            Console.Write("≈:时空隧道,随机倒退,暂停,交换位置");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(2, h - 7);
            Console.Write("★:玩家");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(12, h - 7);
            Console.Write("◆:电脑");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(22, h - 7);
            Console.Write("⊙:玩家和电脑重合");

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(2, h - 5);
            Console.Write("按任意键开始扔色子");
        }
        #endregion

        #region 7 绘制玩家
        static void DrawPlayer(Player player,Player computer,Map map)
        {
            //重合时
            if(player.nowIndex == computer.nowIndex)
            {
                //得到重合位置
                Grid grid = map.grids[player.nowIndex];
                Console.SetCursorPosition(grid.pos.x,grid.pos.y);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("⊙");
            }
            //不重合的时候
            else
            {
                player.Draw(map);
                computer.Draw(map);
            }
        }
        #endregion

        #region 8 扔色子函数
        static void ClearInfo(int w,int h)
        {
            //擦除之前显示的提示信息
            Console.SetCursorPosition(2, h - 5);
            Console.Write("                                          ");
            Console.SetCursorPosition(2, h - 4);
            Console.Write("                                          ");
            Console.SetCursorPosition(2, h - 3);
            Console.Write("                                          ");
            Console.SetCursorPosition(2, h - 2);
            Console.Write("                                          ");
        }

        /// <summary>
        /// 扔色子函数
        /// </summary>
        /// <param name="w">窗口的宽</param>
        /// <param name="h">窗口的高</param>
        /// <param name="p">扔色子的对象</param>
        /// <param name="map">地图信息</param>
        /// <returns>默认为false 表示没有结束</returns>
        static bool RandomMove(int w,int h,ref Player p, ref Player p2, Map map)
        {
            //擦除之前显示的提示信息
            ClearInfo(w,h);
            //根据扔色子的玩家类型决定提示信息颜色
            Console.ForegroundColor = p.type == E_PlayerType.Player ? ConsoleColor.Cyan : ConsoleColor.Magenta;

            //扔色子之前判断玩家是否处于暂停状态
            if (p.isPause)
            {
                Console.SetCursorPosition(2,h - 5);
                Console.Write("处于暂停状态,{0}需要暂停一回合",p.type == E_PlayerType.Player?"你":"电脑");
                Console.SetCursorPosition(2, h - 4);
                Console.Write("请按任意键,让{0}开始扔色子", p.type == E_PlayerType.Player ? "电脑" : "你自己");
                //停止暂停
                p.isPause = false;
                return false;
            }

            //扔色子 随机一个1到6的数 加上去
            Random r = new Random();
            int randomNum = r.Next(1,7);
            p.nowIndex += randomNum;

            //打印扔出的点数
            Console.SetCursorPosition(2, h - 5);
            Console.Write("{0}扔出的点数为:{1}", p.type == E_PlayerType.Player ? "你" : "电脑",randomNum);

            //首先判断是否到终点了
            if (p.nowIndex >= map.grids.Length - 1)
            {
                p.nowIndex = map.grids.Length - 1;
                Console.SetCursorPosition(2, h - 4);
                if (p.type == E_PlayerType.Player)
                {
                    Console.Write("恭喜你,率先到达了终点");
                }
                else
                {
                    Console.Write("很遗憾,电脑率先到达了终点");
                }
                Console.SetCursorPosition(2, h - 3);
                Console.Write("请按任意键结束游戏");
                return true;
            }
            else
            {
                //没有到终点 就判断对象 到了一个怎样的格子 
                Grid grid = map.grids[p.nowIndex];

                switch (grid.type)
                {
                    case E_Grid_Type.Normal:
                        //普通格子不用处理
                        Console.SetCursorPosition(2, h - 4);
                        Console.Write("{0}到达了一个安全位置", p.type == E_PlayerType.Player ? "你" : "电脑");
                        Console.SetCursorPosition(2, h - 3);
                        Console.Write("请按任意键,让{0}开始扔色子", p.type == E_PlayerType.Player ? "电脑" : "你自己");
                        break;
                    case E_Grid_Type.Boom:
                        //炸弹退格
                        p.nowIndex -= 5;
                        //不能比起点还小
                        if(p.nowIndex < 0)
                        {
                            p.nowIndex = 0;
                        }
                        Console.SetCursorPosition(2, h - 4);
                        Console.Write("{0}踩到了炸弹,退后5格", p.type == E_PlayerType.Player ? "你" : "电脑");
                        Console.SetCursorPosition(2, h - 3);
                        Console.Write("请按任意键,让{0}开始扔色子", p.type == E_PlayerType.Player ? "电脑" : "你自己");
                        break;
                    case E_Grid_Type.Pause:
                        //暂停一回合
                        p.isPause = true;
                        Console.SetCursorPosition(2, h - 4);
                        Console.Write("{0}到达了暂停点,需要暂停一回合", p.type == E_PlayerType.Player ? "你" : "电脑");
                        Console.SetCursorPosition(2, h - 3);
                        Console.Write("请按任意键,让{0}开始扔色子", p.type == E_PlayerType.Player ? "电脑" : "你自己");
                        break;
                    case E_Grid_Type.Tunnel:
                        //随机
                        Console.SetCursorPosition(2, h - 4);
                        Console.Write("{0}踩到了时空隧道", p.type == E_PlayerType.Player ? "你" : "电脑");
                        randomNum = r.Next(1,91);
                        //触发退格
                        if(randomNum <= 30)
                        {
                            p.nowIndex -= 5;
                            //不能比起点还小
                            if (p.nowIndex < 0)
                            {
                                p.nowIndex = 0;
                            }
                            Console.SetCursorPosition(2, h - 3);
                            Console.Write("触发倒退5格");
                        }
                        //触发暂停
                        else if(randomNum <= 60)
                        {
                            p.isPause = true;
                            Console.SetCursorPosition(2, h - 3);
                            Console.Write("触发暂停一回合");
                        }
                        //触发交换位置
                        else
                        {
                            int temp = p.nowIndex;
                            p.nowIndex = p2.nowIndex;
                            p2.nowIndex = temp;
                            Console.SetCursorPosition(2, h - 3);
                            Console.Write("中大奖了，双方交换位置");
                        }

                        Console.SetCursorPosition(2, h - 2);
                        Console.Write("请按任意键,让{0}开始扔色子", p.type == E_PlayerType.Player ? "电脑" : "你自己");
                        break;
                }
            }
            //默认没有结束
            return false;
        }
        #endregion
    }

    #region 2 场景选择相关
    /// <summary>
    /// 游戏场景枚举类型
    /// </summary>
    enum E_SceneType
    {
        /// <summary>
        /// 开始场景
        /// </summary>
        Begin,
        /// <summary>
        /// 游戏场景
        /// </summary>
        Game,
        /// <summary>
        /// 结束场景
        /// </summary>
        End,
    }
    #endregion

    #region 5 格子结构体和格子枚举
    /// <summary>
    /// 格子类型 枚举
    /// </summary>
    enum E_Grid_Type
    {
        /// <summary>
        /// 普通格子
        /// </summary>
        Normal,
        /// <summary>
        /// 炸弹
        /// </summary>
        Boom,
        /// <summary>
        /// 暂停
        /// </summary>
        Pause,
        /// <summary>
        /// 时空隧道 随机倒退 暂停 换位置
        /// </summary>
        Tunnel,
    }

    struct Vector2
    {
        public int x;
        public int y;

        public Vector2(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    struct Grid
    { 
        //格子类型
        public E_Grid_Type type;
        //格子位置
        public Vector2 pos;

        public Grid(int x,int y,E_Grid_Type type)
        {
            pos.x = x;
            pos.y = y;
            this.type = type;
        }

        public void Draw()
        {
            //不管选择哪种都要画
            Console.SetCursorPosition(pos.x, pos.y);
            switch (type)
            {
                //普通格子
                case E_Grid_Type.Normal:
                    Console.ForegroundColor= ConsoleColor.White;
                    Console.Write("□");
                    break;
                //炸弹格子
                case E_Grid_Type.Boom:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("●");
                    break;
                //暂停格子
                case E_Grid_Type.Pause:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("‖");
                    break;
                //时空隧道格子
                case E_Grid_Type.Tunnel:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("≈");
                    break;
            }
        }
    }

    #endregion

    #region 6 地图结构体
    struct Map
    {
        public Grid[] grids;
        
        public Map(int x,int y,int num)
        {
            Random r = new Random();
            grids = new Grid[num];
            int randomNum;

            //用于位置改变计数得变量
            //表示x变化的次数
            int indexX = 0;
            //表示y变化的次数
            int indexY = 0;
            //x的步长
            int stepNum = 2;

            for (int i = 0;i < num;i++)
            {
                //初始化格子类型
                randomNum = r.Next(0, 101);

                //设置类型 普通格子
                //有85%几率 是普通(首尾两个格子 必为普通格子)
                if (randomNum < 85 || i == 0 || i == num - 1)
                {
                    grids[i].type = E_Grid_Type.Normal;
                }
                //有5%概率 是炸弹
                else if(randomNum >= 85 && randomNum < 90)
                {
                    grids[i].type = E_Grid_Type.Boom;
                }
                //有5%概率 是暂停
                else if (randomNum >= 90 && randomNum < 95)
                {
                    grids[i].type = E_Grid_Type.Pause;
                }
                //有5%概率 是时空隧道
                else
                {
                    grids[i].type = E_Grid_Type.Tunnel;
                }

                //位置应该如何设置
                grids[i].pos = new Vector2(x,y);

                //加十次
                if(indexX == 10)
                {
                    y += 1;
                    //加一次Y记一次数
                    ++indexY;
                    if(indexY == 2)
                    {
                        //y加了2次过后 把x加的次数计0
                        indexX = 0;
                        indexY = 0;
                        //反向步长
                        stepNum = -stepNum;
                    }
                }
                else
                {
                    x += stepNum;
                    //加一次x记一次数
                    ++indexX;
                }
            }
        }

        public void Draw()
        {
            for(int i = 0; i < grids.Length; ++i)
            {
                grids[i].Draw();
            }
        }
    }

    #endregion

    #region 7 玩家枚举和玩家结构体
    /// <summary>
    /// 玩家类型枚举
    /// </summary>
    enum E_PlayerType
    {
        /// <summary>
        /// 玩家
        /// </summary>
        Player,
        /// <summary>
        /// 电脑
        /// </summary>
        Computer,
    }

    struct Player
    {
        //玩家类型
        public E_PlayerType type;
        //当前所在地图哪一个索引的格子
        public int nowIndex;
        //是否暂停
        public bool isPause;

        public Player(int index,E_PlayerType type)
        {
            nowIndex = index;
            this.type = type;
            isPause = false;
        }

        public void Draw(Map mapInfo)
        {
            //必须要先得到地图 才能够 得到我再地图上的哪一个格子
            //从传入的地图中 得到 格子信息
            Grid grid = mapInfo.grids[nowIndex];
            //设置位置
            Console.SetCursorPosition(grid.pos.x, grid.pos.y);
            //画 设置颜色 设置图标
            switch (type)
            {
                case E_PlayerType.Player:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("★");
                    break;
                case E_PlayerType.Computer:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("◆");
                    break;
            }
        }
    }
    #endregion
}