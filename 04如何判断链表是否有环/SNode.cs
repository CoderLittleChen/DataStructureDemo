using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04如何判断链表是否有环
{
    public class SNode<T>
    {
        //数据域
        private T data;
        //应用域
        private SNode<T> next;

        public SNode(T val,SNode<T> p)
        {
            data = val;
            next = p;
        }

        public  SNode(SNode<T> p)
        {
            next = p;
        }

        public SNode(T val)
        {
            data = val;
        }

        public SNode()
        {
            data = default;
            next = null;
        }

        //数据域属性
        public T Data
        {
            get { return data; }
            set { data = value; }
        }

        //引用域属性
        public SNode<T> Next
        {
            get { return next; }
            set { next = value; }
        }

    }
}
