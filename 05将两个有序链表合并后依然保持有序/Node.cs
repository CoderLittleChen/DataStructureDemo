using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05将两个有序链表合并后依然保持有序
{
    public class Node
    {
        public int Data { get; set; }

        public Node Next { get; set; }

        public  Node(int data)
        {
            this.Data = data;
        }

        public Node(int data,Node  next)
        {
            Data = data;
            Next = next;
        }

    }
}
