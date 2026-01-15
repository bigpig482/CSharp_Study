using System;

namespace Lesson19_练习题
{
    #region 练习题1
    //人、汽车、房子都需要等级，人需要到派出所登记，
    //汽车需要去车管所登记，房子需要去房管局登记
    //使用接口实现登记方法
    interface IRegistration
    {
        void DengJi();
    }
    class Person : IRegistration
    {
        public void DengJi()
        {
            Console.WriteLine("到派出所登记");
        }
    }

    class Car : IRegistration 
    {
        public void DengJi()
        {
            Console.WriteLine("到车管所登记");
        }
    }

    class House : IRegistration
    {
        public void DengJi()
        {
            Console.WriteLine("到房管局登记");
        }
    }
    #endregion

    #region 练习题2
    //麻雀、鸵鸟、企鹅、鹦鹉、直升机、天鹅
    //直升机和部分鸟能飞
    //鸵鸟和企鹅不能飞
    //企鹅和天鹅能游泳
    //除直升机，其它都能走
    //请用面向对象相关知识实现

    //飞行行为
    interface IFly
    {
        void Fly();
    }
    //游泳行为
    interface ISwim
    {
        void Swim();
    }
    //走路行为
    interface IWalk
    {
        void Walk();
    }
    //麻雀
    class Sparrow : IFly, IWalk
    {
        public void Fly()
        {
            Console.WriteLine("麻雀能飞");
        }

        public void Walk()
        {
            Console.WriteLine("麻雀能走");
        }
    }
    //鸵鸟
    class Ostrich : IWalk
    {
        public void Walk()
        {
            Console.WriteLine("鸵鸟能走");
        }
    }
    //企鹅
    class Penguin : ISwim, IWalk
    {
        public void Swim()
        {
            Console.WriteLine("企鹅能游泳");
        }
        public void Walk()
        {
            Console.WriteLine("企鹅能走");
        }
    }
    //鹦鹉
    class Parrot : IFly,IWalk
    {
        public void Fly()
        {
            Console.WriteLine("鹦鹉能飞");
        }
        public void Walk()
        {
            Console.WriteLine("鹦鹉能走");
        }
    }
    //直升机
    class Helicopter : IFly
    {
        public void Fly()
        {
            Console.WriteLine("直升机能飞");
        }
    }
    //天鹅
    class Swan : IFly,ISwim,IWalk
    {
        public void Fly()
        {
            Console.WriteLine("天鹅能飞");
        }
        public void Swim()
        {
            Console.WriteLine("天鹅能游泳");
        }
        public void Walk()
        {
            Console.WriteLine("天鹅能走");
        }
    }
    #endregion

    #region 练习题3
    //多态来模拟移动硬盘、U盘、MP3查到电脑上读取数据
    //移动硬盘与U盘都属于存储设备
    //MP3属于播放设备
    //但他们都能插在电脑上传输数据
    //电脑提供了一个USB接口
    //请实现电脑的传输数据的功能

    //传输数据
    interface IUSB
    {
        void ReadData();
    }
    //存储设备
    abstract class StorageDevice
    {

    }
    //播放设备
    abstract class PlaybackDevice
    {
        
    }
    //硬盘
    class HardDrive : StorageDevice, IUSB
    {
        public void ReadData()
        {
            Console.WriteLine("硬盘");
        }
    }
    //U盘
    class USBFlashDrive : StorageDevice, IUSB
    {
        public void ReadData()
        {
            Console.WriteLine("U盘");
        }
    }
    //MP3
    class MP3 : PlaybackDevice, IUSB
    {
        public void ReadData()
        {
            Console.WriteLine("MP3");
        }
    }
    //电脑
    class Computer
    {
        public IUSB iusb;
    }
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("接口练习题");

            #region 练习题1
            Person p = new Person();
            p.DengJi();
            IRegistration c = new Car();
            c.DengJi();
            House h = new House();
            h.DengJi();
            #endregion

            #region 练习题2
            Sparrow sparrow = new Sparrow();
            sparrow.Fly();
            sparrow.Walk();
            Ostrich ostrich = new Ostrich();
            ostrich.Walk();
            Penguin penguin = new Penguin();
            penguin.Walk();
            penguin.Swim();
            Parrot parrot = new Parrot();
            parrot.Walk();
            parrot.Fly();
            Helicopter helicopter = new Helicopter();
            helicopter.Fly();
            Swan swan = new Swan();
            swan.Walk();
            swan.Fly();
            swan.Swim();
            #endregion

            #region 练习题3
            HardDrive hd = new HardDrive();
            USBFlashDrive ud = new USBFlashDrive();
            MP3 mP3 = new MP3();

            Computer cpt = new Computer();
            cpt.iusb = hd;
            cpt.iusb.ReadData();

            cpt.iusb = ud;
            cpt.iusb.ReadData();

            cpt.iusb = mP3;
            cpt.iusb.ReadData();
            #endregion
        }
    }
}