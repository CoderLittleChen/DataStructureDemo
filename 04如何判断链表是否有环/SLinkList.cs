using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04如何判断链表是否有环
{
    class SLinkList<T>
    {
        //单链表的头引用
        public SNode<T> start;
        //单链表的长度
        public int length;
        public SLinkList()
        {
            start = null;
        }


        /// <summary>
        /// 插入节点
        /// </summary>
        /// <param name="val"></param>
        /// <param name="i"></param>
        public void InsertNode(SNode<T> val, int i)
        {
            SNode<T> current;
            SNode<T> previous;

            if (i < 1)
            {
                Console.WriteLine("Postion is Error !");
                return;
            }
            SNode<T> newnode = new SNode<T>(val);
            //在空链表或第一个元素前插入第一个元素
            if (i == 1)
            {
                newnode.Next = start;
                start = newnode;
                length++;
                return;
            }
            //单链表的两个元素间插入一个元素
            //使current指向第一个结点
            current = start;
            previous = null;

            int j = 1;
            while (current != null && j < i)
            {
                //使previous指向curent
                previous = current;
                //使current指向序列中的下一个结点
                current = current.Next;
                j++;
            }
            if (j == i)
            {
                previous.Next = newnode;
                newnode.Next = current;
                length++;
            }
        }


        public bool IsEmpty()
        {
            if (start == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// 查找节点
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public SNode<T> SearchNode(int i)
        {
            if (IsEmpty())
            {
                Console.WriteLine("Link is Empty !");
                return null;
            }
            SNode<T> current = start;
            int j = 1;

            while (current.Next != null && j < i)
            {
                current = current.Next;//使current指向序列中的下一个结点 直到i
                j++;
            }
            if (j == i)
            {
                return current;
            }
            else
            {
                Console.WriteLine("The {0}th node is no exsit !", i);
                return null;
            }
        }


    }
}
