using System;

namespace Lesson16_练习题
{
    //反转 .Reverse();
    #region 练习题1
    //写一个怪物类，创建10个怪物将其添加到List中
    //对List列表进行排序，根据用户输入数字进行排序
    //1、攻击排序
    //2、防御排序
    //3、血量排序
    //4、反转
    //enum E_Sort
    //{
    //    atkSort,
    //    defSort,
    //    hpSort,
    //    fSort,
    //}
    class Monster : IComparable<Monster>
    {
        public int atk;
        public int def;
        public int hp;

        public Monster(int atk,int def,int hp)
        {
            this.atk = atk;
            this.def = def;
            this.hp = hp;
        }

        public int CompareTo(Monster? other)
        {
            return 0;
        }
    }
    #endregion

    //111
    #region 练习题2
    //写一个物品类（类型，名字，品质），创建10个物品
    //添加到List中
    //同时使用类型、品质、名字长度进行比较
    //排序的权重是：类型 > 品质 > 名字长度
    class Item
    {
        public string name;
        public int type;
        public int quality;

        public Item(string name,int type,int quality)
        {
            this .name = name;
            this .type = type;
            this .quality = quality;
        }
    }
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("List排序练习题");
            #region 练习题1
            List<Monster> list = new List<Monster>();
            Random r = new Random();
            int a;
            for (int i = 0;i < 10;i++)
            {
                list.Add(new Monster(r.Next(11, 21), r.Next(1, 11), r.Next(50, 100)));
            }

            for (int i = 0;i < list.Count;i++)
            {
                Console.WriteLine("怪物{0}的攻击力为{1}，防御力为{2}，血量为{3}", i, list[i].atk, list[i].def, list[i].hp);
            }

            try
            {
                //while (true)
                //{
                    Console.WriteLine("请输入你要排序的内容（1攻击排序 2防御排序 3血量排序 4反转）");
                    switch (a = int.Parse(Console.ReadLine()))
                    {
                        case 1:
                            list.Sort((a, b) =>
                            {
                                return a.atk > b.atk ? 1 : -1;
                            });
                            break;
                        case 2:
                            list.Sort((a, b) =>
                            {
                                return a.def > b.def ? 1 : -1;
                            });
                            break;
                        case 3:
                            list.Sort((a, b) =>
                            {
                                return a.hp > b.hp ? 1 : -1;
                            });
                            break;
                        case 4:
                            //反转
                            list.Reverse();
                            break;
                    }
                    for (int i = 0; i < list.Count; i++)
                    {
                        Console.WriteLine("怪物{0}的攻击力为{1}，防御力为{2}，血量为{3}", i, list[i].atk, list[i].def, list[i].hp);
                    }
                }
               
            //}
            catch 
            {
                Console.WriteLine("请输入正确的数字");
            }


            #endregion

            #region 练习题2
            List<Item> items = new List<Item>();
            for (int i = 0;i < 10;i++)
            {
                items.Add(new Item(string.Format("物品{0}",r.Next(0,200)),r.Next(1,6), r.Next(1, 6)));
            }

            for(int i = 0;i < items.Count;i++)
            {
                Console.WriteLine("类型:{0}，名字:{1}，品质{2}", items[i].type, items[i].name, items[i].quality);
            }

            items.Sort((a,b) =>
            {
                if(a.type != b.type)
                {
                    return a.type > b.type ? -1 : 1;
                }
                else if(a.quality != b.quality)
                {
                    return a.quality > b.quality ? -1 : 1;
                }
                else
                {
                    return a.name.Length > b.name.Length ? -1 : 1;
                }
            });

            Console.WriteLine("----------------");
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine("类型:{0}，名字:{1}，品质{2}", items[i].type, items[i].name, items[i].quality);
            }
            #endregion

            #region 练习题3
            //linq SQL
            //请尝试利用List排序方式对Dictionary中的内容排序
            //提示：得到Dictionary的所有键值对信息存入List中
            Dictionary<int,string> dic = new Dictionary<int,string>();
            dic.Add(3, "老王");
            dic.Add(2, "老李");
            dic.Add(6, "老蒯");
            dic.Add(1, "雨姐");
            dic.Add(5, "奶龙");
            dic.Add(4, "贝利亚");
            List<KeyValuePair<int, string>> dicList = new List<KeyValuePair<int, string>>();
            foreach(KeyValuePair<int,string> item in dic)
            {
                dicList.Add(item);
                Console.WriteLine(item.Key + "_" + item.Value);
            }
            dicList.Sort((a,b) =>
            {
                return a.Key > b.Key ? 1 : -1;
            });
            
            for (int i = 0;i < dicList.Count;i++)
            {
                Console.WriteLine(dicList[i].Key + "_" + dicList[i].Value);
            }
            #endregion
        }
    }
}
