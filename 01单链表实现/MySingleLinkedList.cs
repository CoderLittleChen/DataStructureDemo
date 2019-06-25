using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01单链表实现
{
    //单链表模拟实现
    public class MySingleLinkedList<T>
    {
        public MySingleLinkedList()
        {
            //构造函数为字段赋值   
            count = 0;
            head = null;
        }
        //当前链表结点个数
        private int count;
        //链表的头结点
        private Node<T> head;

        //是只读的     
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

        //根据索引获取结点        根据索引获取结点
        private Node<T> GetNodeByIndex(int index)
        {
            //首先判断索引是否超出界限
            if (index < 0 || index >= count)
            {
                throw new ArgumentOutOfRangeException("index", "索引超出界限");
            }
            //将头结点赋值给临时节点  
            Node<T> tempNode = head;
            for (int i = 0; i < index; i++)
            {
                //通过循环将下一个结点赋值给临时结点  
                tempNode = tempNode.Next;
            }
            return tempNode;
        }

        /// <summary>
        /// 在尾结点后插入新结点
        /// </summary>
        /// <param name="value"></param>
        public void Add(T value)
        {
            //根据value值新建Node结点
            Node<T> newNode = new Node<T>(value);
            //判断当前链表中是否存在结点，没有就作为头结点
            if (count == 0)
            {
                head = newNode;
            }
            else
            {
                //先找到当前链表中的最后一个结点,头结点索引为0 
                Node<T> lastNode = GetNodeByIndex(count - 1);
                //最后一个结点的Next属性指向新结点  
                lastNode.Next = newNode;
            }
            //链表结点数量增加
            count++;
        }

        /// <summary>
        /// 在指定位置插入结点
        /// </summary>
        /// <param name="index"></param>
        /// <param name="value"></param>
        public void Insert(int index, T value)
        {
            //根据Value值new一个新的结点
            Node<T> newNode = new Node<T>(value);
            //首先要判断索引参数是否超出界限
            if (index < 0 || index > count - 1)
            {
                throw new ArgumentOutOfRangeException("index", "索引超出界限");
            }
            //这里还要判断为头结点的情况
            else if (index == 0)
            {
                //还要判断当前链表中是否存在结点
                if (count == 0)
                {
                    //插入的结点作为头结点
                    head = newNode;
                }
                else
                {
                    newNode.Next = head;
                    head = newNode;
                }
            }
            else
            {
                //获取当前结点的上一个结点
                Node<T> prevNode = GetNodeByIndex(index - 1);
                //把原结点指向下一结点的指针赋值给新结点
                newNode.Next = prevNode.Next;
                prevNode.Next = newNode;
            }
            //最后count++
            count++;
        }

        /// <summary>
        /// 移除指定位置的结点
        /// </summary>
        /// <param name="index"></param>
        public void RemoveAt(int index)
        {
            if (index < 0 || index > count - 1)
            {
                throw new ArgumentOutOfRangeException("index", "索引超出界限");
            }
            //感觉还是要判断移除头结点和尾结点的情况    
            if (index == 0)
            {
                head = head.Next;
            }
            else if (index == count - 1)
            {
                GetNodeByIndex(index - 1).Next = null;
            }
            else
            {
                Node<T> prevNode = GetNodeByIndex(index - 1);
                Node<T> deleteNode = prevNode.Next;
                prevNode.Next = deleteNode.Next;
            }
            count--;
        }


    }
}
