using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01单链表实现
{
    public class Node<T>
    {
        public Node()
        {
        }

        //单链表结构上分为  数据域和指针域
        //而双链表分为 数据域和头指针和尾指针 
        public Node(T item)
        { 
            Item = item;
        }         
        
        //定义数据域   
        public T Item { get; set; }


        //定义指针域,指向后继节点   
        public Node<T> Next { get; set; }


    }
}
  