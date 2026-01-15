using System;

namespace Lesson13_练习题
{
    #region 练习题
    //有一个热水器，包含一个加热器，一个报警器，一个显示器
    //我们给热水器通上电，当水温超过95度时
    //1.报警器会开始发出语音，告诉你谁的温度
    //2.显示器也会改变水温提示，提示水已经烧开了
    class Heater
    {
        public event Action<int> myEvent;

        private int value = 0;
        public void AddHot()
        {
            int updateIndex = 0;
            while(true)
            {
                if(updateIndex % 9999999 == 0)
                {
                    ++value;
                    Console.WriteLine("加热到{0}度",value);
                    if(value >= 100)
                    {
                        break;
                    }
                    //温度超过95度 就触发 报警器和显示器显示消息
                    if(value >= 95)
                    {
                        if (myEvent != null)
                        {
                            myEvent(value);
                        }
                        //只想提示一次就置空
                        myEvent = null;
                    }

                    //隔一段时间 加一点温度
                    updateIndex = 0;
                }
                ++updateIndex;
            }
            
        }
    }

    class Alarm
    {
        public void ShowInfo(int v)
        {
            Console.WriteLine("当前水温{0}度",v);
        }
    }

    class Monitor
    {
        public void ShowInfo(int v)
        {
            Console.WriteLine("水已经开了,当前水温{0}度",v);
        }
    }
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("事件练习题");
            Heater h = new Heater();
            Alarm a = new Alarm();
            Monitor m = new Monitor();
            h.myEvent += a.ShowInfo;
            h.myEvent += m.ShowInfo;
            h.AddHot();
        }
    }
}
