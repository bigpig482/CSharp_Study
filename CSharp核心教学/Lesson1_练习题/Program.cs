using System;

namespace Lesson1_练习题
{
    #region 练习题1
    //将下面的事物进行分类，可重复
    //机器人、机器、人、猫、张阿姨、隔壁老王、汽车、飞机、向日葵、
    //菊花、太阳、星星、荷花
    //机器人 机器 汽车 飞机
    //人 张阿姨 隔壁老王
    //向日葵 菊花 荷花
    //太阳 星星
    #endregion

    #region 练习题2
    //GameObject A = new GameObject():
    //GameObject B = A;
    //B =null;
    //A目前等于多少?

    //A不为空
    #endregion

    #region 练习题3
    //GameObject A = new GameObject():
    //GameObject B = A;
    //B = new GameObject():
    //A和B有什么关系？

    //没有关系 各自在堆中有自己分配的空间
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("类和对象练习题");
        }
    }
}