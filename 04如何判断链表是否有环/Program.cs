using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04如何判断链表是否有环
{
    class Program
    {
        static void Main(string[] args)
        {
            //基本思路 定义两个指针slow和fast，slow走一步，fast走两步  
            //若一段时间后  重合 说明有环

            SLinkList<int> link = new SLinkList<int>();
            SNode<int> node = new SNode<int>(1);
            link.InsertNode(node, 1);
            link.InsertNode(node, 2);
            link.InsertNode(node, 3);
            SNode<int> c = link.SearchNode(3);
            link.InsertNode(node, 4);
            link.InsertNode(node, 5);
            while (link.start.Next != null)
            {
                link.start = link.start.Next;
            }
            link.start.Next = c;
            Console.WriteLine(IsCircle(link));
            Console.ReadLine();

        }


        public static int IsCircle<T>(SLinkList<T> link)
        {
            SNode<T> fast = link.start;
            SNode<T> slow = link.start;
            while (link.start.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next;
                if (fast != null && fast.Next != null)
                {
                    fast = fast.Next;
                }
                else
                {
                    return 0;
                }
                link.start = link.start.Next;
                if (fast == slow)
                {
                    return 1;
                }
            }
            return 0;
        }

    }
}
