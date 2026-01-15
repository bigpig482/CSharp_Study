using System;

namespace Lesson6_练习题
{
    //111
    #region 练习题
    //自定义一个整形数组类,该类中有一个整形数组变量
    //为它封装增删改查的方法
    class ArrOfInt
    {
        int[] array;
        //房间容量
        int capacity;
        //当前放了几个房间
        int length;

        public ArrOfInt()
        {
            capacity = 5;
            length = 0;
            array = new int[capacity];
        }

        //增加
        public void Add(int value)
        {
            if(length < capacity)
            {
                //填充
                array[length] = value;
                length++;
            }
            else
            {
                //扩容
                capacity *= 2;
                int[] arr = new int[capacity];
                for (int i = 0; i < array.Length; i++)
                {
                    arr[i] = array[i];
                }
                array = arr;

                //填充
                array[length] = value;
                length++;
            }
        }

        //删除
        public void Remove(int value)
        {
            for (int i = 0;i < length;i++)
            {
                if (array[i] == value)
                {
                    RemoveAt(i);
                    return;
                } 
            }
            Console.WriteLine("没有在数组中找到{0}",value);
        }

        public void RemoveAt(int index)
        {
            if (index > length - 1)
            {
                Console.WriteLine("当前数组只有{0},你越界了",length);
                return;
            }
            for(int i = index;i < length - 1;i++)
            {
                array[i] = array[i + 1];
            }
            --length;
        }
        //查找
        public int this[int index]
        {
            get
            {
                if (index < array.Length)
                {
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (array[index] == array[i])
                        {
                            Console.WriteLine("找到了第{0}个元素,它的值为{1}", i, array[i]);
                        }
                    }
                    return array[index];
                }
                else
                {
                    Console.WriteLine("越界");
                    return 0;
                }
            }
            set
            {
                //修改
                if(index < array.Length)
                {
                    array[index] = value;
                }
                else
                {
                    Console.WriteLine("越界");
                }
            }
        }

        //属性
        public int Length
        {
            get
            {
                return length;
            }
        }
    }
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("索引器练习题");
            ArrOfInt array = new ArrOfInt();
            array.Add(1);
            array.Add(2);
            array.Add(3);
            array.Add(4);
            array.Add(5);
            array.RemoveAt(1);
            array.Remove(5);
            array.Remove(6);
            Console.WriteLine(array[0]);
            Console.WriteLine(array[1]);
        }
    }
}