using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01单链表实现
{
    class Program
    {
        static void Main(string[] args)
        {
            //Logic Structure   Physical Structure  Storage Structure(存储结构)
            Demo();
            Console.ReadKey();
        }
        static void Demo()
        {
            MySingleLinkedList<int> list = new MySingleLinkedList<int>();
            //顺序插入四个结点
            list.Add(0);
            list.Add(1);
            list.Add(2);
            list.Add(3);
            Console.WriteLine("The Nodes in the List");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i]+"  ");
            }
            Console.WriteLine("\n----------------------------------------");
            //索引为0的位置插入单个结点
            list.Insert(0, 11);
            list.Insert(0, 22);
            list.Insert(0, 33);
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + "  ");
            }
            Console.WriteLine("\n----------------------------------------");
            //移除索引为5的结点
            list.RemoveAt(5);
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + "  ");
            }
            Console.WriteLine("\n----------------------------------------");
            //移除索引为0的结点
            list.RemoveAt(0);
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + "  ");
            }
            Console.WriteLine("\n----------------------------------------");
            //
            list.RemoveAt(1);
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + "  ");
            }
            Console.WriteLine("\n----------------------------------------");
            //向末尾插入结点
            list.Add(1111111);
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + "  ");
            }
            Console.WriteLine("\n----------------------------------------");
            //移除索引为2的元素
            list.RemoveAt(2);
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + "  ");
            }
            Console.WriteLine("\n----------------------------------------");
        }
    }
}
