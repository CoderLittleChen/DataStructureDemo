using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03循环链表的实现
{
    public class CirNode<T>
    {
        //循环结点只有一个指针域，一个数据域
        public CirNode()
        {
        }
        public CirNode(T item)
        {
            this.item = item;
        }
        public T item { get; set; }
        public CirNode<T> Next { get; set; }
    }
}
