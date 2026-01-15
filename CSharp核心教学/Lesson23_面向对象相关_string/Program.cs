using System;

namespace Lesson23_面向对象相关_string

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("变量");

            #region 知识点一 字符串指定位置获取
            //字符串本质是char数组
            string str = "唐老师";
            Console.WriteLine(str[0]);
            //转为char数组 ToCharArray()
            char[] chars = str.ToCharArray();
            Console.WriteLine(chars[1]);

            for(int i = 0;i < str.Length;i++)
            {
                Console.WriteLine(str[i]);
            }
            #endregion
            //string.Format()
            #region 知识点二 字符串拼接
            str = string.Format("{0}{1}",1,23);
            Console.WriteLine(str);
            #endregion
            //IndexOf()
            #region 知识点三 正向查找字符位置
            //IndexOf() 找到返回第一个字的索引值 没找到返回-1
            str = "我是毒液！";
            int index = str.IndexOf("毒");
            Console.WriteLine(index);

            index = str.IndexOf("6");
            Console.WriteLine(index);
            #endregion
            //LastIndexOf()
            #region 知识点四 反向查找指定字符串位置
            //LastIndexOf()
            str = "我是毒液我是毒液";

            index = str.LastIndexOf("毒液");
            Console.WriteLine(index);

            index = str.LastIndexOf("我是最强毒液");
            Console.WriteLine(index);
            #endregion
            //Remove()
            #region 知识点五 移除指定位置后的字符
            //Remove(n) 包括输入的位置
            str = "我是毒液，我是毒液，我是最强毒液";
            str.Remove(9);
            Console.WriteLine(str);
            str = str.Remove(9);
            Console.WriteLine(str);

            //Remove(x,y) x开始位置 y字符个数 从开始位置开始移除 使用时注意范围
            str = "我是毒液，我是毒液，我是最强毒液";
            str = str.Remove(9,2);
            Console.WriteLine(str);
            #endregion
            //Replace()
            #region 知识点六 替换指定字符串
            //Replace(x,y) x想替换的字符 y新字符
            str = "我是奶龙，我才是奶龙";
            str = str.Replace("奶龙","贝利亚");
            Console.WriteLine(str);
            #endregion
            //ToUpper() ToLower()
            #region 知识点七 大小写转换
            //转成大写ToUpper() 转成小写ToLower()
            str = "abcdefg";
            str = str.ToUpper();
            Console.WriteLine(str);

            str = str.ToLower();
            Console.WriteLine(str);
            #endregion
            //Substring()
            #region 知识点八 字符串截取
            //Substring()
            str = "我要玩原神";
            str = str.Substring(2);
            Console.WriteLine(str);

            //Substring(x,y) x开始位置 y指定个数 使用时注意范围
            str = "我要玩原神";
            str = str.Substring(1,3);
            Console.WriteLine(str);
            #endregion
            //Split()
            #region 知识点九 字符串切割
            //Split()
            str = "1,2,3,4,5,6";
            string[] strs = str.Split(',');
            for(int i = 0;i < strs.Length;i++)
            {
                Console.WriteLine(strs[i]);
            }
            #endregion
        }
    }
}