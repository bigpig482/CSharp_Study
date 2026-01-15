using System;

namespace 必备知识点_控制台相关
{
    class Program
    {
        //1.如何打断点 F9
        //2.如何一步一步看代码逻辑 F10
        //3.继续执行 停止一步一步的看 F5
        //4.可以通过监视窗口查看想要的到的变量值

        static void Main(string[] args)
        {
            Console.WriteLine("控制台相关");

            #region 知识点一 复习 输入 输出
            //输出
            //Console.WriteLine("123456");
            //Console.Write("123456");

            //输入
            //string str = Console.ReadLine();

            //如果在ReadKey(true)不会把输入的内容显示在控制台上
            //char c = Console.ReadKey(true).KeyChar;
            //Console.WriteLine(c);
            #endregion

            #region 知识点二 控制台其他方法
            //1.清空
            //Console.Clear();

            //2.设置控制台大小
            //窗口大小 缓冲区大小
            //注意:
            //先设置窗口大小，再设置缓冲区大小
            //缓冲区的大小不能小于窗口的大小
            //窗口的大小不能大于控制台的最大尺寸

            //窗口大小
            //Console.SetWindowSize(100,50);

            //缓冲区大小(可打印内容区域的宽高)
            //Console.SetBufferSize(1000,1000);

            //3.设置光标的位置
            //控制台左上角为原点0 0 右侧是x轴正方向 下方是Y轴正方形 它是一个平面二维坐标系
            //注意:
            //边界问题
            //横纵距离单位不同 1y = 2x 视觉上的
            //Console.SetCursorPosition(0, 1);
            //Console.WriteLine("123123");

            //4.设置颜色相关
            //文字颜色设置
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine("123456");
            //Console.ForegroundColor = ConsoleColor.Green;

            //背景颜色设置
            //Console.BackgroundColor = ConsoleColor.White;
            //重置背景颜色过后 需要clear一次 才能把整个背景颜色改变
            //Console.Clear();

            //5.光标显影
            //Console.CursorVisible = false;

            //6.关闭控制台
            //Environment.Exit(0);
            #endregion

            #region 练习题
            //通过WASD键在控制台中控制一个黄色方块上下左右移动
            //注意:边界问题

            Console.SetWindowSize(100,100);
            Console.SetBufferSize(1000,1000);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.CursorVisible = false;

            char c;
            int x = 0, y = 0;

            while (true)
            {
                //第一种方式
                //Console.Clear();
                Console.SetCursorPosition(x, y);
                Console.Write("■");
                c = Console.ReadKey(true).KeyChar;
                //第二种方式
                Console.SetCursorPosition(x, y);
                Console.Write(" ");
                switch (c)
                {
                    case 'W':
                    case 'w':
                        //Console.Clear();
                        y -= 1;
                        if (y < 0)
                        {
                            y = 0;
                        }
                        break;

                    case 'A':
                    case 'a':
                        //Console.Clear();
                        x -= 2;
                        if (x < 0)
                        {
                            x = 0;
                        }
                        break;

                    case 'S':
                    case 's':
                        //Console.Clear();
                        y += 1;
                        if (y > Console.BufferHeight - 1)
                        {
                            y = Console.BufferHeight - 1;
                        }
                        break;

                    case 'D':
                    case 'd':
                        //Console.Clear();
                        x += 2;
                        if (x > Console.BufferWidth - 2)
                        {
                            x = Console.BufferWidth - 2;
                        }
                        break;

                    default:
                        break;
                }
                
            }

            
            #endregion
        }
    }
}
