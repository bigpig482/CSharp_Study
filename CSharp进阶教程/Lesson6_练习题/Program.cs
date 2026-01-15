using System;

namespace Lesson6_练习题
{
    #region 练习题1
    //用泛型实现一个单例模式基类

    class SingleBase<T> where T : new()
    {
        private static T instance = new T();

        public static T Instance
        {
            get
            {
                return instance;
            }
        }
    }

    class Test
    {
        private static Test instance = new Test();

        public static Test Instance
        {
            get
            {
                return instance;
            }
        }
        private Test()
        {

        }
    }
    #endregion

    #region 练习题2
    //利用泛型知识点，仿造ArrayList实现一个不确定数组类型的类
    //实现增删查改方法
    class ArrayList<T> where T : struct
    {
        private T[] array;
        //当前存了多少数
        private int count;

        public int Capacity
        {
            get
            {
                return array.Length;
            }
        }

        public int Count
        {
            get
            {
                return count;
            }
        }
        public ArrayList()
        {
            array = new T[16];
            count = 0;
        }

        public void Add(T value)
        {
            //是否需要扩容
            if(count >= Capacity)
            {
                //搬家 扩容两倍
                T[] newArray = new T[Capacity * 2];
                for(int i = 0; i < Capacity; i++)
                {
                    newArray[i] = array[i];
                }
                //重新指向地址
                array = newArray;
            }
            //加
            array[count] = value;
            count++;
        }

        public void Remove(T value)
        {
            int index = -1;
            //小于具体存了多少值
            for(int i = 0;i < Count;i++)
            {
                //不能用==判断 不是所有类型都重载了运算符
                if (array[i].Equals(value))
                {
                    //下标
                    index = i;
                    break;
                }
            }
            //不等于-1 说明找到了
            if (index != -1)
            {
                RemoveAt(index);
            }
        }

        public void RemoveAt(int index)
        {
            //索引合法不
            if(index < 0 || index >= Count)
            {
                Console.WriteLine("索引不合法");
                return;
            }

            //后面的往前放
            for (; index < Count - 1; index++)
            {
                //往前移
                array[index] = array[index + 1];
            }
            array[Count - 1] = default(T);
            count--;
        }

        public T this[int index]
        {
            get
            {
                //索引合法不
                if (index < 0 || index >= Count)
                {
                    Console.WriteLine("索引不合法");
                    return default(T);
                }
                return array[index];
            }
            set
            {
                //索引合法不
                if (index < 0 || index >= Count)
                {
                    Console.WriteLine("索引不合法");
                    return;
                }
                array[index] = value;
            }
        }
    }
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("泛型约束练习题");
            ArrayList<int> array = new ArrayList<int>();
        }
    }
}