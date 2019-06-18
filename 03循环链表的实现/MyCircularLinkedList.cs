using _03循环链表的实现;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03循环链表的实现
{
    public class MyCircularLinkedList<T>
    {
        public MyCircularLinkedList()
        {
            count = 0;
            tail = null;
        }
        //记录数据元素个数  
        private int count { get; set; }
        //尾结点
        private CirNode<T> tail { get; set; }
        //前驱结点来标识当前结点    这里定义的当前节点就是在单链表中的头结点  
        //只不过是用当前节点的上一个节点来表示当前节点
        private CirNode<T> currentPrev { get; set; }

        public int Count
        {
            get
            {
                return count;
            }
        }

        public T CurrentItem
        {
            get
            {
                return currentPrev.Next.item;
            }
        }

        //当前循环链接是否为空
        public bool IsEmpty()
        {
            return tail == null;
        }

        //根据索引获取结点
        public CirNode<T> GetNodeByIndex(int index)
        {
            //先判断索引是否越界
            if (index < 0 || index > Count - 1)
            {
                throw new ArgumentOutOfRangeException("索引越界");
            }
            //根据指定的尾节点  来获取到表面意思上的头结点
            CirNode<T> tempNode = tail.Next;
            for (int i = 0; i < index; i++)
            {
                tempNode = tempNode.Next;
            }
            return tempNode;
        }

        //在尾结点后插入新结点
        public void Add(T value)
        {
            CirNode<T> newNode = new CirNode<T>(value);
            //判断当前链表是否为空
            if (Count <= 0)
            {
                //插入的该节点就是尾节点  这里要注意是循环链表 
                tail = newNode;
                tail.Next = tail;
                currentPrev = tail;
            }
            else
            {
                //当前循环链表非空 则插入到链表尾部  

                //插入到链表末尾处
                newNode.Next = tail.Next;
                //改变当前节点  其实就是改变头结点的前驱节点
                if (currentPrev == tail)
                {
                    currentPrev = newNode;
                }
                //给新的尾节点赋值
                tail = newNode;
            }
            count++;
        }

        //循环链表当前节点的移除实现
        public void RemoveNode()
        {
            //判断当前节点是否存在元素
            if (tail == null)
            {
                throw new NullReferenceException("链表中没有任何元素!");
            }
            else
            {
                if (currentPrev.Next == tail)
                {
                    tail = currentPrev;
                }
                //这里是为什么？
                currentPrev.Next = currentPrev.Next.Next;
            }
        }


    }
}
