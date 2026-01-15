using System;

namespace Lesson18_练习题
{
    #region 练习题
    //控制台中有一个■
    //它会如贪食蛇一样自动移动
    //请开启一个多线程来检测输入，控制它的转向
    #endregion
    enum E_Dic
    {
        Up,
        Down, 
        Left, 
        Right,
    }

    class Icon
    {
        public E_Dic dic;
        public int x;
        public int y;

        public Icon(int x,int y, E_Dic dic)
        {
            this.x = x;
            this.y = y;
            this.dic = dic;
        }

        public void Move()
        {
            switch (dic)
            {
                case E_Dic.Up:
                    y -= 1;
                    if (y < 0)
                    {
                        y = 0;
                    }
                    break;
                case E_Dic.Down:
                    y += 1;
                    if(y > 20)
                    {
                        y = 20;
                    }
                    break;
                case E_Dic.Left:
                    x -= 2;
                    if(x < 0)
                    {
                        x = 0;
                    }
                    break;
                case E_Dic.Right:
                    x += 2;
                    if (x > 50)
                    {
                        x = 50;
                    }
                    break;
            }
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("■");
        }

        public void Clear()
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine("  ");
        }

        public void ChangeDic(E_Dic dic)
        {
            this.dic = dic;
        }
    }
    class Program
    {
        static bool isRunning = true;

        static Icon icon;
        static void Main(string[] args)
        {
            //Console.WriteLine("多线程练习题");
            Console.CursorVisible = false;
            Console.SetWindowSize(50, 20);
            Console.SetBufferSize(50, 20);
            icon = new Icon(10, 4,E_Dic.Right);
            icon.Draw();
            Thread t = new Thread(NewThreadLogic);
            t.Start();
            while (isRunning)
            {
                Thread.Sleep(500);
                icon.Clear();
                icon.Move();
                icon.Draw();
            }
        }
        static void NewThreadLogic()
        {
            while (isRunning)
            {
                switch(Console.ReadKey(true).Key)
                {
                    case ConsoleKey.W:
                        icon.ChangeDic(E_Dic.Up);
                        break;
                    case ConsoleKey.A:
                        icon.ChangeDic(E_Dic.Left);
                        break;
                    case ConsoleKey.S:
                        icon.ChangeDic(E_Dic.Down);
                        break;
                    case ConsoleKey.D:
                        icon.ChangeDic(E_Dic.Right);
                        break;
                }
            }
        }
    }
}
