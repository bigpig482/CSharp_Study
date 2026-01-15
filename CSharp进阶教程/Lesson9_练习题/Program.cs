using System;

namespace Lesson9_练习题
{
    #region 练习题1
    //请说出常用的数据结构有哪些

    //数组、栈、队列、链表、树、图、堆、散列表(哈希表)
    #endregion

    //111
    #region 练习题2
    //请描述顺序存储和链式存储的区别

    //顺序存储:内存中用一组地址连续的存储单元存储线性表(连续地址存储)
    //链式存储:内存中用一组任意的存储单元存储线性表(任意地址存储)
    #endregion

    #region 练习题3
    //请尝试自己实现一个双向链表
    //并提供以下方法和属性
    //数据的个数，头节点，尾节点
    //增加数据到链表最后
    //删除指定位置节点

    class LinkedNode<T>
    {
        public T value;
        public LinkedNode<T> nextNode;
        public LinkedNode<T> upNode;

        public LinkedNode(T value)
        {
            this.value = value;
        }
    }

    class LinkedList<T>
    {
        public LinkedNode<T> head;
        public LinkedNode<T> tail;
        public int count = 0;

        public int Count
        {
            get
            {
                return count;
            }
        }

        public LinkedNode<T> Head
        {
            get
            {
                return head;
            }
        }

        public LinkedNode<T> Tail
        {
            get
            {
                return tail;
            }
        }
        public void Add(T value)
        {
            LinkedNode<T> node = new LinkedNode<T>(value);
            if (head == null)
            {
                head = node;
                tail = node;
                //head.nextNode = tail;
                //tail.upNode = head;
            }
            else
            {
                //添加尾部
                tail.nextNode = node;
                //记录上一个节点
                node.upNode = tail;
                tail = node;
            }
            count++;
        }

        public void Remove(int index)
        {
            if(index >= count || index < 0 )
            {
                Console.WriteLine("只有{0}个节点",count);
                return;
            }
            int tempCount = 0;
            LinkedNode<T> tempNode = head;
            while (true)
            {
                //找到移除
                if(tempCount == index)
                {
                    if(tempNode.upNode != null)
                    {
                        tempNode.upNode.nextNode = tempNode.nextNode;
                    } 
                    if(tempNode.nextNode != null)
                    {
                        tempNode.nextNode.upNode = tempNode.upNode;
                    }
                    if(index == 0)
                    {
                        //移除头节点
                        head = tempNode.nextNode;
                    }
                    else if(index == count - 1)
                    {
                        //移除尾节点
                        tail = tail.upNode;
                    }
                    count--;
                    break;
                }
                tempNode = tempNode.nextNode;
                tempCount++;
            }
            //if (head == null)
            //{
            //    return;
            //}
            //if(head.value.Equals(index))
            //{
            //    head.nextNode.upNode = null;
            //    head = head.nextNode;
            //    if (head == null)
            //    {
            //        tail = null;
            //    }
            //}
            //LinkedNode<T> tempNode = head;
            //while (tempNode.nextNode != null)
            //{
            //    if(tempNode.nextNode.value.Equals(index))
            //    {
            //        tempNode.nextNode = tempNode.nextNode.nextNode;
            //        tempNode.nextNode.upNode = tempNode;
            //        if (tempNode.nextNode.value.Equals(tail.value))
            //        { 
            //            tail = tempNode;
            //        }
            //    }
            //    tempNode = tempNode.nextNode;
            //}
            //count--;
        }
    }

    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("顺序存储和链式存储练习题");
            LinkedList<int> link = new LinkedList<int>();
            link.Add(1);
            link.Add(2);
            link.Add(3);
            link.Add(4);
            //正向遍历
            LinkedNode<int> node = link.Head;
            while (node != null)
            {
                Console.WriteLine(node.value);
                node = node.nextNode;
            }

            //反向遍历
            node = link.Tail;
            while (node != null)
            {
                Console.WriteLine(node.value);
                node = node.upNode;
            }
        }
    }
}
