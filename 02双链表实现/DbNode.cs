using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02双链表实现
{
    public class DbNode<T>
    {
        public DbNode()
        {
        }
        public DbNode(T item)
        {
            Item = item;
        }
        //这里的Item表示结点的数据域
        public T Item { get; set; }
        public DbNode<T> Prev { get; set; }
        public DbNode<T> Next { get; set; }
    }
}
