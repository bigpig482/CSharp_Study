using System;
using System.Collections;

namespace Lesson22_练习题
{
    #region 练习题
    //请为一个自定义类
    //用两种方法让其可以被foreach遍历
    class Test : IEnumerator,IEnumerable
    {
        private int[] ints;
        private int Index = -1;
        public Test()
        {
            ints = new int[] { 1, 3, 5, 7, 9, 11 };
        }

        public object Current
        {
            get
            {
                return ints[Index];
            }
        }

        public IEnumerator GetEnumerator()
        {
            Reset();
            return this;
        }

        public bool MoveNext()
        {
            ++Index;
            return Index < ints.Length;
        }

        public void Reset()
        {
            Index = -1;
        }
    }

    class Test<T> : IEnumerable where T : class 
    {
        private T[] array;
        public Test(params T[] array)
        {
            this.array = array;
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < array.Length; ++i)
            {
                yield return array[i];
            }
        }
    }
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("迭代器练习题");
            Test t = new Test();
            foreach(int i in t)
            {
                Console.WriteLine(i);
            }

            Test<string> t2 = new Test<string>(new string[] { "奶龙", "贝利亚", "奥特曼", "老王" });
            foreach(string i in t2)
            {
                Console.WriteLine(i);
            }
        }
    }
}