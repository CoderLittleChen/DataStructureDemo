using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05将两个有序链表合并后依然保持有序
{
    class Program
    {
        static void Main(string[] args)
        {
            //解题思路  
            //定义一个执行新链表的指针  暂且指向Null
            //比较两个链表的头结点，让较小的头结点作为新链表的头结点
            //递归比较两个链表的其余结点，让较小的结点作为上一个新结点的后一个结点

            //这里目前都是用结点来实现的，后续尝试怎样用链表来实现


        }


        /// <summary>
        /// 有序链表合并
        /// </summary>
        /// <param name="head1"></param>
        /// <param name="head2"></param>
        /// <returns></returns>
        public Node Merge(Node head1, Node head2)
        {
            if (head1 == null)
            {
                return head2;
            }
            else if (head2 == null)
            {
                return head1;
            }
            Node newHead = null;
            if (head1.Data < head2.Data)
            {
                newHead = head1;
                //确定头结点的下一个节点
                newHead.Next = Merge(head1.Next, head2);
            }
            else
            {
                newHead = head2;
                newHead.Next = Merge(head1, head2.Next));
            }
            return newHead;
        }



    }
}
