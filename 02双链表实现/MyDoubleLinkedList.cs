using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02双链表实现
{
    public class MyDoubleLinkedList<T>
    {
        private int count;
        private DbNode<T> head;
        public int Count
        {
            get
            {
                return count;
            }
        }

        //索引器
        public T this[int index]
        {
            get
            {
                return GetNodeByIndex(index).Item;
            }
            set
            {
                GetNodeByIndex(index).Item = value;
            }
        }
        /// <summary>
        /// 根据索引获取结点
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public DbNode<T> GetNodeByIndex(int index)
        {
            //首先判断index是否超出界限
            if (index < 0 || index > count - 1)
            {
                throw new ArgumentOutOfRangeException("index", "索引超出界限");
            }
            //先把头结点赋值
            DbNode<T> tempNode = head;
            for (int i = 0; i < index; i++)
            {
                tempNode = tempNode.Next;
            }
            return tempNode;
        }
        /// <summary>
        /// 在尾结点之后插入新结点
        /// </summary>
        /// <param name="value"></param>
        public void AddAfter(T value)
        {
            DbNode<T> newNode = new DbNode<T>(value);
            //这里判断当前链表是否存在结点
            if (head == null)
            {
                //插入头结点
                head = newNode;
            }
            else
            {
                //根据索引获取尾结点
                DbNode<T> lastNode = GetNodeByIndex(count - 1);
                lastNode.Next = newNode;
                newNode.Prev = lastNode;
                newNode.Next = null;
            }
            count++;
        }

        /// <summary>
        /// 在尾结点之前插入结点
        /// </summary>
        /// <param name="value"></param>
        public void AddBefore(T value)
        {
            DbNode<T> newNode = new DbNode<T>(value);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                DbNode<T> lastNode = GetNodeByIndex(count - 1);
                lastNode.Prev.Next = newNode;
                newNode.Prev = lastNode.Prev;
                newNode.Next = lastNode;
                lastNode.Prev = newNode;
            }
            count++;
        }

        /// <summary>
        /// 指定位置后插入新结点
        /// </summary>
        /// <param name="index"></param>
        /// <param name="value"></param>
        public void InsertAfter(int index, T value)
        {

            //先判断index是否合法
            if (index < 0 || index > count - 1)
            {
                throw new ArgumentOutOfRangeException("index", "索引超出界限");
            }
            //根据Value值拿到结点
            DbNode<T> newNode = new DbNode<T>(value);
            //拿到当前索引对应的结点
            DbNode<T> currentNode = GetNodeByIndex(index);
            //拿到当前索引下一个结点
            DbNode<T> nextNode = GetNodeByIndex(index + 1);
            if (index == 0)
            {
                if (head == null)
                {
                    //插入头结点
                    head = newNode;
                }
                else
                {
                    head.Next = newNode;
                    newNode.Prev = head;
                    newNode.Next = nextNode;
                    nextNode.Prev = newNode;
                }
            }
            else
            {
                currentNode.Next = newNode;
                newNode.Prev = currentNode;
                newNode.Next = nextNode;
                newNode.Prev = newNode;
            }
            count++;
        }

        /// <summary>
        /// 指定位置前插入结点
        /// </summary>
        /// <param name="index"></param>
        /// <param name="value"></param>
        public void InsertBefore(int index, T value)
        {
            if (index < 0 || index > count - 1)
            {
                throw new ArgumentOutOfRangeException("index", "索引超出界限");
            }
            DbNode<T> newNode = new DbNode<T>(value);
            DbNode<T> currentNode = GetNodeByIndex(index);
            if (index == 0)
            {
                if (head == null)
                {
                    head = newNode;
                }
                else
                {
                    newNode.Next = head;
                    head.Prev = newNode;
                    head = newNode;
                }
            }
            else
            {
                DbNode<T> prevNode = GetNodeByIndex(index - 1);
                prevNode.Next = newNode;
                newNode.Prev = prevNode;
                newNode.Next = currentNode;
                currentNode.Prev = newNode;
            }
            count++;
        }

        /// <summary>
        /// 移除指定结点
        /// </summary>
        /// <param name="index"></param>
        public void RemoveAt(int index)
        {
            if (index < 0 || index > count - 1)
            {
                throw new ArgumentOutOfRangeException("index", "索引超出界限");
            }
            //还是要判断头结点和尾结点的情况
            if (index == 0)
            {
                //移除头结点
                head = head.Next;
            }
            else if (index == count - 1)
            {
                //移除尾结点
                DbNode<T> prevNode = GetNodeByIndex(index - 1);
                DbNode<T> currentNode = GetNodeByIndex(index);
                prevNode.Next = null;
                currentNode.Next = null;
            }
            else
            {
                //移除中间结点的情况
                DbNode<T> prevNode = GetNodeByIndex(index - 1);
                DbNode<T> nextNode = GetNodeByIndex(index + 1);
                prevNode.Next = nextNode;
                nextNode.Prev = prevNode;
            }
            count--;
        }

    }
}
