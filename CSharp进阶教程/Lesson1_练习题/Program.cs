using System;
using System.Collections;

namespace Lesson1_练习题
{
    #region 练习题一
    //请简述ArrayList和数组的区别

    //ArrayList本质上是一个object数组的封装

    //1.ArrayList可以不用一开始就定长，单独使用数组是定长的
    //2.数组可以指定存储类型，ArrayList默认为object类型
    //3.数组的增删需要我们自己去实现，ArrayList帮我们封装了方便的API来使用
    //4.ArrayList使用时可能存在装箱拆箱，数组使用时只要不是object数组那就不存在这个问题
    //5.数组长度为Length，ArrayList长度为Count
    #endregion

    #region 练习题二
    //创建一个背包管理类，使用ArrayList存储物品,实现购买物品,卖出物品,显示物品的功能，购买与卖出物品会导致金钱变化。
    //abstract class BpManagement : IBuy,ISell,IDisplay
    //{
    //    public ArrayList item;
    //    public int money;

    //    /// <summary>
    //    /// 买入物品
    //    /// </summary>
    //    /// <exception cref="NotImplementedException"></exception>
    //    public void Buy(Item i)
    //    {
    //        if(money - i.ibuyvalue < 0)
    //        {
    //            Console.WriteLine("钱不够，无法购买");
    //        }
    //        else
    //        {
    //            money -= i.ibuyvalue;
    //            Console.WriteLine("剩余的钱为{0}",money);
    //            AddItem(i);
    //        }
    //    }
    //    /// <summary>
    //    /// 卖出物品
    //    /// </summary>
    //    /// <param name="i"></param>
    //    public void Sell(Item i)
    //    {
    //        RemoveItem(i);
    //        money += i.ivalue;
    //        Console.WriteLine("剩余的钱为{0}", money);
    //    }
    //    /// <summary>
    //    /// 显示物品
    //    /// </summary>
    //    public void Display()
    //    {
    //        if (item.Count == 0)
    //        {
    //            Console.WriteLine("背包里没有物品，无法查看");
    //        }
    //        for (int i = 0; i < item.Count; i++)
    //        {
    //                Console.WriteLine(item[i]);
    //        }
    //        //foreach (object i in item)
    //        //{
    //        //    Console.WriteLine(i);
    //        //}
    //    }
    //    //增加物品
    //    protected void AddItem(Item i)
    //    {
    //        item.Add(i);
    //    }
    //    //删除物品
    //    protected void RemoveItem(Item i)
    //    {
    //        item.Remove(i);
    //    }
    //}

    //class Backpack : BpManagement
    //{
    //    public Backpack()
    //    {
    //        item = new ArrayList();
    //        money = 10;
    //    }
    //}
    //class Item
    //{
    //    //一般用来确定是哪个物品
    //    //public int ID;
    //    public string name;
    //    public int ivalue;
    //    public int ibuyvalue;

    //    public Item()
    //    {
    //        name = "苹果";
    //        ivalue = 1;
    //        ibuyvalue = 2;
    //    }

    //    public Item(string name,int ivalue,int ibuyvalue)
    //    {
    //        this.name = name;
    //        this.ivalue = ivalue;
    //        this.ibuyvalue = ibuyvalue;
    //    }

    //    public override string ToString()
    //    {
    //        return string.Format("物品名称{0}，物品价值{1}，购入价格{2}",name,ivalue,ibuyvalue);
    //    }
    //}
    //interface IBuy
    //{
    //    public void Buy(Item i);
    //}

    //interface ISell
    //{
    //    public void Sell(Item i);
    //}

    //interface IDisplay
    //{
    //    public void Display();
    //}
    #endregion

    class BagMgr
    {
        //背包中的物品
        private ArrayList items;
        private int money;

        //构造函数
        public BagMgr(int money)
        {
            this.money = money;
            items = new ArrayList();
        }

        //买的时候最好不要用id 和 name 来会创造新对象不合理
        //卖的时候是从背包内已经有的对象来获取id 和 name
        public void BuyItem(Item item)
        {
            if(item.num <= 0 || item.money < 0)
            {
                Console.WriteLine("请传入正确的物品信息");
                return;
            }
            //买不起情况
            if(this.money < item.money * item.num)
            {
                Console.WriteLine("买不起，钱不够");
                return;
            }
            //减钱
            this.money -= item.money * item.num;
            Console.WriteLine("购买{0}{1}个花费{2}钱",item.name,item.num,item.money * item.num);
            Console.WriteLine("剩余{0}元钱",money);
            //叠加物品，加数量
            for(int i = 0;i < items.Count;i++)
            {
                if ((items[i] as Item).Id == item.Id)
                {
                    (items[i] as Item).num += item.num;
                    return;
                }
            }
            //把一组物品加到list中
            items.Add(item);
        }

        public void SellItem(Item item)
        {
            for(int i = 0;i < items.Count;i++)
            {
                //如何判断 卖的东西我有没有
                //这是在判断 两个引用地址 指向的是不是同一个房间
                //一般卖东西不会这样判断
                //if (items[i] == item)
                //{

                //}
                if ((items[i] as Item).Id == item.Id)
                {
                    int num = 0;
                    string name = (items[i] as Item).name;
                    int money = (items[i] as Item).money;
                    if ((items[i] as Item).num > item.num)
                    {
                        //1.比我身上的少
                        num = item.num;
                    }
                    else
                    {
                        //2.比我身上的多
                        num = (items[i] as Item).num;
                        //卖完了 移除
                        items.RemoveAt(i);
                    }

                    int sellMoney = (int)(num * money * 0.8f);
                    this.money += sellMoney;
                    Console.WriteLine("卖了{0}{1}个，赚了{2}钱", name,num,sellMoney);
                    Console.WriteLine("目前拥有{0}元钱",this.money);

                    return;
                }
            }
        }

        public void SellItem(int id,int num = 1)
        {
            Item item = new Item(id,num);
            SellItem(item);
        }

        public void SellItem(string name)
        {

        }

        public void ShowItem()
        {
            Item item;
            for(int i = 0;i < items.Count;i++)
            {
                item = items[i] as Item;
                Console.WriteLine("有{0}{1}个",item.name,item.num);
            }
            Console.WriteLine("当前有{0}元钱",money);
        }
    }

    class Item
    {
        //物品唯一ID 来区分物品种类
        public int Id;
        //物品名字
        public string name;
        //物品价值
        public int money;
        //物品数量
        public int num;

        public Item()
        {

        }

        public Item(int Id,int num)
        {
            this.Id = Id;
            this.num = num;
        }

        public Item(int Id,string name,int money,int num)
        {
            this.Id = Id;
            this.name = name;
            this.money = money;
            this.num = num;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ArrayList练习题");
            //Item item = new Item();
            //Backpack bp = new Backpack();
            //bp.Buy(item);
            //bp.Display();
            //bp.Sell(item);
            //bp.Display();

            BagMgr bag = new BagMgr(999999);
            Item i1 = new Item(1,"血药",10,10);
            Item i2 = new Item(2, "蓝药",20,10);
            Item i3 = new Item(3, "屠龙宝刀",999,1);

            bag.BuyItem(i1);
            bag.BuyItem(i2);
            bag.BuyItem(i3);

            bag.SellItem(i3);

            bag.ShowItem();
        }
    }
}
