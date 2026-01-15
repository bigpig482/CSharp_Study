using System;
using System.Collections;
using System.Collections.Generic;

namespace Lesson8_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dictionary");

            #region 知识点一 Dictionary的本质
            //可以将Dictionary理解为 拥有泛型的Hashtable
            //它也是基于键的哈希代码组织起来的 键/值对
            //键值对类型从Hashtable的object变为了可以自己制定的泛型
            #endregion

            #region 知识点二 申明
            //引用命名空间
            //using System.Collections.Generic;
            Dictionary<int,string> dictionary = new Dictionary<int,string>();
            #endregion

            #region 知识点三 增删查改

            #region 增
            //注意:不能出现相同键
            dictionary.Add(1,"123");
            dictionary.Add(2, "222");
            dictionary.Add(3, "222");
            #endregion

            #region 删
            //1.只能通过键去删除
            //  删除不存在键 没反应
            dictionary.Remove(3);
            dictionary.Remove(4);

            //2.清空
            dictionary.Clear();

            dictionary.Add(1, "123");
            dictionary.Add(2, "222");
            dictionary.Add(3, "222");
            #endregion

            #region 查
            //1.通过键查看值
            //  找不到直接报错
            Console.WriteLine(dictionary[1]);
            //Console.WriteLine(dictionary[4]);

            //2.查看是否存在
            //  根据键检测
            if(dictionary.ContainsKey(1))
            {
                Console.WriteLine("存在键为1的键值对");
            }

            //  根据值检测
            if (dictionary.ContainsValue("222"))
            {
                Console.WriteLine("存在值为222的键值对");
            }
            #endregion

            #region 改
            Console.WriteLine(dictionary[2]);
            dictionary[2] = "456";
            Console.WriteLine(dictionary[2]);
            #endregion

            #endregion

            #region 知识点四 遍历
            //1.遍历所有键
            foreach(int key in dictionary.Keys)
            {
                Console.WriteLine("键:" + key);
                Console.WriteLine("值:" + dictionary[key]);
            }

            //2.遍历所有值
            foreach(string value in dictionary.Values)
            {
                Console.WriteLine("值:" + value);
            }
            //3.键值对一起遍历
            foreach(KeyValuePair<int,string> ky in dictionary)
            {
                Console.WriteLine("键:{0} 值:{1}",ky.Key,ky.Value);
            }
            #endregion
        }
    }
}
