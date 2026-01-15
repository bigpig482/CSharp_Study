using System;

namespace Lesson16_练习题
{
    //111
    #region 练习题
    //定义一个载具类,速度,最大速度,可乘人数,司机和顾客等，有人上车，下车，行驶，车祸等方法，
    //用载具类声明一个对象 并将若干个人装载上车
    class Car
    {
        //当前有多少人
        public int num;
        public int speed;
        public int maxSpeed;
        public Person[] persons;

        #region 失败的man
        //public string name;
        //public Driver driver;
        //public Customer[] customers;
        //public Vehicle()
        //{
        //    name = "小客车";
        //    number = 4;
        //    speed = 60;
        //    maxSpeed = 120;
        //    length = 0;
        //    customers = new Customer[number];
        //    driver = new Driver();
        //}

        //public Vehicle(int number, string name) : this()
        //{
        //    this.name = name;
        //    this.number = number;
        //}
        ////上车
        //public void GetUp(Customer c)
        //{
        //    if (length + 1 < number)
        //    {
        //        if (customers[0] == null)
        //        {
        //            customers[0] = c;
        //            length++;
        //        }
        //        else
        //        {
        //            customers[length] = c;
        //            length++;
        //        }
        //        Console.WriteLine("{0}上车了,现在有{1}个乘客", c.cname, length + 1);
        //    }
        //    else
        //    {
        //        Console.WriteLine("乘客已满");
        //    }
        //}
        ////下车
        //public void GetDown(Customer c)
        //{
        //    if (customers[0] == null)
        //    {
        //        Console.WriteLine("车上没有乘客");
        //    }
        //    else
        //    {
        //        customers[length] = null;
        //    }
        //}
        ////行驶
        //public void Drive(Driver d)
        //{
        //    //Random r = new Random();
        //    speed = 60;
        //    Console.WriteLine("{0}正在安全驾驶,驾驶速度为{1}", d.dname, speed);
        //}
        ////车祸
        //public void CarAccident(Vehicle v)
        //{

        //}
        #endregion

        public Car(int speed,int maxSpeed,int num)
        {
            this.speed = speed;
            this.maxSpeed = maxSpeed;
            this.num = 0;
            persons = new Person[num];
        }

        //上车
        public void GetUp(Person p)
        {
            if(num >= persons.Length)
            {
                Console.WriteLine("满载");
                return;
            }
            persons[num] = p;
            ++num;
        }

        //下车
        public void GetDown(Person p)
        {
            for(int i = 0;i < persons.Length;i++)
            {
                if (persons[i] == null)
                {
                    break;
                }
                if (persons[i] == p)
                {
                    //移动位置
                    for(int j = i;j < num - 1;j++)
                    {
                        persons[j] = persons[i + 1];
                    }
                    //最后一个位置清空
                    persons[num - 1] = null;
                    num--;
                    break;
                }
            }
        }

        //行驶

        //车祸
    }

    class Person
    {
        
    }
    class Driver : Person
    {
       
    }

    class Customer : Person
    {
        
    }

    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("密封类练习题");
            Car c = new Car(10,20,20);
            Driver d = new Driver();
            c.GetUp(d);

            Person p = new Person();
            c.GetUp(p);
            Person p1 = new Person();
            c.GetUp(p1);
            Person p2 = new Person();
            c.GetUp(p2);

            c.GetDown(p2);
        }
    }
}
