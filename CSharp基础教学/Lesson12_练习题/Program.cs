using System;
using System.Reflection;
using System.Threading;

namespace Lesson12_练习题
{
    #region 练习题1
    //使用结构体描述学员的信息，姓名，性别，年龄，班级，专业，
    //创建两个学员对象，并对其基本信息进行初始化并打印
    struct Student
    {
        public string name;
        public bool sex;
        public int age;
        public int classId;
        public string major;

        public Student(string name,bool sex,int age,int classId,string major)
        {
            this.name = name;
            this.sex = sex;
            this.age = age;
            this.classId = classId;
            this.major = major;
        }

        public void Print()
        {
            Console.WriteLine("姓名:{0}\n性别:{1}\n年龄:{2}\n班级:{3}\n专业:{4}\n",name,sex ?"男":"女",age,classId,major);
        }
    }
    #endregion

    #region 练习题2
    //请简要描述private和public两个关键字的区别
    //private只能在结构体内部使用 public可以被外部使用
    #endregion

    #region 练习题3
    //使用结构体描述矩形的信息，长，宽；创建一个矩形，对其长宽进行
    //初始化，并打印矩形的长、宽、面积、周长等信息。
    struct Rectangle
    {
        public int long1;
        public int width;
        public int area;
        public int perimeter;

        public Rectangle(int long1,int width)
        {
            this.long1 = long1;
            this.width = width;
            area = long1 * width;
            perimeter = 2 * (long1 + width);
        }

        public void Print()
        {
            Console.WriteLine("矩形的长为{0}，宽为{1}，面积为{2}，周长为{3}",long1,width,area,perimeter);
        }
    }
    #endregion

    #region 练习题4
    //请用户输入玩家姓名，选择玩家职业，最后打印玩家的攻击信息
    //职业:
    //战士（技能：冲铎）
    //猎人(技能：假死）
    //法师（技能：奥术冲击）
    //打印结果：猎人唐老狮释放了假死

    //struct PlayerInfo
    //{
    //    public string playername;
    //    public string occupation;
    //    public string skill;

    //    public PlayerInfo(string playername,int a)
    //    {
    //        this.playername = playername;
    //        if(a == 1)
    //        {
    //            occupation = "战士";
    //            skill = "冲锋";
    //        }
    //        else if(a == 2)
    //        {
    //            occupation = "猎人";
    //            skill = "假死";
    //        }
    //        else if (a == 3)
    //        {
    //            occupation = "法师";
    //            skill = "奥数冲击";
    //        }
    //        else
    //        {
    //            Console.WriteLine("请输入正确的数字");
    //        }
    //    }

    //    public void Print()
    //    {
    //        Console.WriteLine("{0}{1}释放了{2}",occupation,playername,skill);
    //    }
    //}
    struct PlayerInfo
    {
        public string name;
        public E_Occupation occupation;

        public PlayerInfo(string name,E_Occupation occupation)
        {
            this .name = name;
            this .occupation = occupation;
        }

        public void Atk()
        {
            string occ = "";
            string skill = "";
            switch (occupation)
            {
                case E_Occupation.Warrior:
                    occ = "战士";
                    skill = "冲锋";
                    //Console.WriteLine("战士{0}释放了冲锋",name);
                    break;
                case E_Occupation.Hunter:
                    occ = "猎人";
                    skill = "假死";
                    //Console.WriteLine("猎人{0}释放了假死",name);
                    break;
                case E_Occupation.Master:
                    occ = "法师";
                    skill = "奥术冲击";
                    //Console.WriteLine("法师{0}释放了奥术冲击",name);
                    break;
                default:
                    break;
            }
            Console.WriteLine("{0}{1}释放了{2}",occ,name,skill);
        }
    }

    enum E_Occupation
    { 
        Warrior,
        Hunter,
        Master,
    }
    #endregion

    #region 练习题5
    //使用结构体描述小怪兽
    //struct Monster
    //{
    //    public string mtrname;
    //    public int mtrHp;
    //    public int mtrAtk;
    //    public int mtrId;
    //    public Random r = new Random();

    //    public Monster(int i)
    //    {
    //        mtrname = "小怪兽" + i;
    //        mtrHp = 100;
    //        mtrAtk = r.Next(8,13);
    //        mtrId = i;
    //    }

    //    public void Print()
    //    {
    //        Console.WriteLine("{0}攻击力:{1}",mtrname,mtrAtk);
    //    }
    //}

    struct Monster
    {
        public string name;
        public int atk;

        public Monster(string name)
        {
            this.name = name;
            Random r = new Random();
            atk = r.Next(10,30);
        }

        public void Atk()
        {
            Console.WriteLine("{0}攻击力:{1}", name, atk);
        }
    }
    #endregion

    //111
    #region 练习题6
    //定义一个数组存储10个上面描述的小怪兽，每个小怪兽的名字为（小怪兽|数组下标)
    //举例：小怪兽0，最后打印10个小怪兽的名字+攻击力数值

    #endregion

    //111
    #region 练习题7
    //应用已学过的知识，实现奥特曼打小怪兽
    //提示：
    //结构休描述奥特曼与小怪兽
    //定义一个方法实现奥特曼攻击小怪兽
    //定义一个方法实现小怪兽攻击奥特曼
    //struct Ultraman
    //{
    //    public string ultname;
    //    public int ultHp;
    //    public int ultAtk;
    //    public string mtrname;
    //    public int mtrHp;
    //    public int mtrAtk;
    //    public Random r = new Random();

    //    public Ultraman()
    //    {
    //        ultname = "奥特曼";
    //        mtrname = "小怪兽";
    //        ultHp = 100;
    //        ultAtk = r.Next(8,13);
    //        mtrHp = 100;
    //        mtrAtk= r.Next(8,12);
    //    }

    //    public void UAtkM()
    //    {
    //        if(mtrHp > 0)
    //        {
    //            ultAtk = r.Next(8, 13);
    //            mtrHp -= ultAtk;
    //            if(mtrHp < 0)
    //            {
    //                Console.WriteLine("小怪兽被奥特曼打败了");
    //            }
    //            Console.WriteLine("{0}剩余血量为{1}",mtrname, mtrHp);
    //            //return mtrHp;
    //        }
    //    }
    //    public void MAktU()
    //    {
    //        if(ultHp > 0)
    //        {
    //            mtrAtk = r.Next(8, 12);
    //            ultHp -= mtrAtk;
    //            if(ultHp < 0)
    //            {
    //                Console.WriteLine("奥特曼被小怪兽打败了");
    //            }
    //            Console.WriteLine("{0}剩余血量为{1}",ultname, ultHp);
    //            //return ultHp;
    //        }
            
    //    }
    //}
    struct OutMan
    {
        public string name;
        public int atk;
        public int def;
        public int hp;

        public OutMan(string name,int atk,int def,int hp)
        {
            this .name = name;
            this .atk = atk;
            this .def = def;
            this .hp = hp;
        }

        public void Atk(ref Boss monster)
        {
            //结构体是值类型 想要在函数内部改变值类型信息 外部受影响 一定要用 ref 或 out
            //奥特曼打小怪兽逻辑
            monster.hp -= atk - monster.def;
            Console.WriteLine("{0}攻击了{1},造成了{2}点伤害,{3}剩余血量{4}",name,monster.name, atk - monster.def,monster.name,monster.hp);
        }
    }

    struct Boss
    {
        public string name;
        public int atk;
        public int def;
        public int hp;

        public Boss(string name, int atk, int def, int hp)
        {
            this.name = name;
            this.atk = atk;
            this.def = def;
            this.hp = hp;
        }

        public void Atk(ref OutMan outman)
        {
            //小怪兽打奥特曼逻辑
            outman.hp -= atk - outman.def;
            Console.WriteLine("{0}攻击了{1},造成了{2}点伤害,{3}剩余血量{4}", name, outman.name, atk - outman.def, outman.name, outman.hp);
        }
    }
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("结构体练习题");
            Console.WriteLine("练习题1");
            Student s1 = new Student("秦靖杰",true,21,1,"矿");
            s1.Print();
            Student s2 = new Student("王俊豪", true, 22, 2, "自动化");
            s2.Print();

            Console.WriteLine();
            Console.WriteLine("练习题2");
            Console.WriteLine("private只能在结构体内部使用 public可以被外部使用");

            Console.WriteLine();
            Console.WriteLine("练习题3");
            Rectangle re1 = new Rectangle(4, 5);
            re1.Print();

            Console.WriteLine();
            Console.WriteLine("练习题4");
            //try
            //{
            //    Console.WriteLine("请输入玩家姓名，和玩家职业(1战士 2猎人 3法师)");
            //    PlayerInfo p1 = new PlayerInfo(Console.ReadLine(), int.Parse(Console.ReadLine()));
            //    p1.Print();
            //}
            //catch
            //{
            //    Console.WriteLine("请输入正确的内容");
            //}
            Console.WriteLine("请输入你的姓名");
            string name = Console.ReadLine();
            Console.WriteLine("请输入职业(1战士 2猎人 3法师)");
            try
            {
                E_Occupation o = (E_Occupation)int.Parse(Console.ReadLine());
                PlayerInfo info = new PlayerInfo(name,o);
                info.Atk();
            }
            catch 
            {
                Console.WriteLine("请输入数字");
            }

            Console.WriteLine();
            Console.WriteLine("练习题5");


            Console.WriteLine();
            Console.WriteLine("练习题6");
            Monster[] mtrarray = new Monster[10];
            for (int i = 0; i < mtrarray.Length; i++)
            {
                mtrarray[i] = new Monster("小怪兽" + i);
                mtrarray[i].Atk();
                //m0.Print();
            }


            Console.WriteLine();
            Console.WriteLine("练习题7");
            //Ultraman u1 = new Ultraman();
            //while(u1.mtrHp > 0 && u1.ultHp > 0)
            //{
            //    u1.UAtkM();
            //    u1.MAktU();
            //}
            OutMan outMan = new OutMan("迪迦奥特曼",10,5,100);
            Boss boss = new Boss("哥斯拉",8,4,100);

            while (true)
            {
                outMan.Atk(ref boss);
                if(boss.hp <= 0)
                {
                    Console.WriteLine("{0}胜利",outMan.name);
                    break;
                }
                boss.Atk(ref outMan);
                if (boss.hp <= 0)
                {
                    Console.WriteLine("{0}胜利",boss.name);
                    break;
                }
                Console.WriteLine();
                Console.ReadKey(true);
            }
        }
    }
}