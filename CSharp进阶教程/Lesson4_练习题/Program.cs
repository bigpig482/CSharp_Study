using System;
using System.Collections;

namespace Lesson4_练习题
{
    #region 练习题一
    //请描述Hashtable的存储规则
    //一个键值对形式存储的 容器
    //一个键 对应一个值
    //类型是object
    #endregion

    #region 练习题二
    //制作一个怪物管理器,提供创建怪物，移除怪物的方法。每个怪物都有自己的唯一ID
    //class MonsterMgr
    //{
    //    public Hashtable hashtable;

    //    public MonsterMgr()
    //    {
    //        hashtable = new Hashtable();
    //    }

    //    public void AddMonster(Monster m)
    //    {
    //        hashtable.Add(m.id,m.name);
    //    }

    //    public void RemoveMonster(Monster m)
    //    {
    //        hashtable.Remove(m.id);
    //    }


    //}

    //class Monster
    //{
    //    public Monster(string name,int id)
    //    {
    //        this.name = name;
    //        this.id = id;
    //    }

    //    public string name;
    //    public int id;
    //}
    #endregion

    class MonsterMgr
    {
        private static MonsterMgr instance = new MonsterMgr();

        private Hashtable monstersTable = new Hashtable();

        private int monsterID = 0;
        private MonsterMgr()
        {

        }
        public static MonsterMgr Instance
        {
            get
            { 
                return instance; 
            }
        }
        public void AddMonster()
        {
            Monster monster = new Monster(monsterID);
            Console.WriteLine("创建了ID为{0}的怪物",monsterID);
            ++monsterID;

            monstersTable.Add(monster.id,monster);
        }

        public void RemoveMonster(int monstersID)
        {
            if(monstersTable.Contains(monstersID))
            {
                (monstersTable[monstersID] as Monster).Dead();
                monstersTable.Remove(monstersID);
            }
        }
    }

    class Monster
    {
        public int id;

        public Monster(int id)
        {
            this.id = id;
        }

        public void Dead()
        {
            Console.WriteLine("怪物{0}死亡",id);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hashtable练习题");
            MonsterMgr.Instance.AddMonster();
            MonsterMgr.Instance.AddMonster();
            MonsterMgr.Instance.AddMonster();
            MonsterMgr.Instance.AddMonster();
            MonsterMgr.Instance.AddMonster();

            MonsterMgr.Instance.RemoveMonster(1);
            MonsterMgr.Instance.RemoveMonster(3);
            //MonsterMgr monsterMgr = new MonsterMgr();
            //Monster m1 = new Monster("小王",1);
            //Monster m2 = new Monster("小明", 2);
            //Monster m3 = new Monster("小秦", 3);
            //monsterMgr.AddMonster(m1);
            //monsterMgr.AddMonster(m2);
            //monsterMgr.AddMonster(m3);

            //foreach(object o in monsterMgr.hashtable.Keys)
            //{
            //    Console.WriteLine("Id:{0}",o);
            //    Console.WriteLine("姓名:{0}", monsterMgr.hashtable[o]);
            //}
        }
        
    }
}
