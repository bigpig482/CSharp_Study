using System;
using System.Net.Http.Headers;
using System.Text;

namespace Lesson8_练习题
{
    #region 练习题1
    //使用字典存储0~9的数字对应的大写文字
    //提示用户输入一个不超过三位的数，提供一个方法，返回数的大写
    //例如：306，返回叁零陆
    #endregion

    #region 练习题2
    //计算每个字母出现的次数“WelcometoUnityWorld！”，使用字典
    //存储，最后遍历整个字典，不区分大小写
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dictionary练习题");

            #region 练习题1
            try
            {
                Console.WriteLine("请输入一个不超过三位的数");
                int a = int.Parse(Console.ReadLine());
                Dictionary<int, string> d1 = new Dictionary<int, string>();
                d1.Add(0, "零");
                d1.Add(1, "壹");
                d1.Add(2, "贰");
                d1.Add(3, "叁");
                d1.Add(4, "肆");
                d1.Add(5, "伍");
                d1.Add(6, "陆");
                d1.Add(7, "柒");
                d1.Add(8, "捌");
                d1.Add(9, "玖");
                Print(a,d1);
            }
            catch
            {
                Console.WriteLine("请输入一个不超过三位的数");
            }
            #endregion

            #region 练习题2
            Dictionary<char,int> d2 = new Dictionary<char,int>();
            string str = "WelcometoUnityWorld";
            str = str.ToLower();
            for (int i = 0; i < str.Length; i++)
            {
                if (d2.ContainsKey(str[i]))
                {
                    d2[str[i]] += 1;
                }
                else
                {
                    d2.Add(str[i], 1);
                }
            }

            foreach(char item in d2.Keys)
            {
                Console.WriteLine("字母{0}出现了{1}次", item, d2[item]);
            }
            #endregion
        }

        public static void Print(int a,Dictionary<int,string> d)
        {
            if(a > 999)
            {
                Console.WriteLine("超过三位数");
                return;
            }
            else if (a < 0)
            {
                Console.WriteLine("小于零");
                return;
            }
            else
            {
                //个位
                int x1 = a % 10;
                //十位
                int x2 = a % 100 / 10;
                //百位
                int x3 = a / 100;
                if (a < 10)
                {
                    Console.WriteLine("{0},零零{1}", a, d[x1]);
                }
                else if(a < 100)
                {
                    Console.WriteLine("{0},零{1}{2}", a, d[x2], d[x1]);
                }
                else
                {
                    Console.WriteLine("{0},{1}{2}{3}", a, d[x3], d[x2], d[x1]);
                }
            }
        }
    }
}