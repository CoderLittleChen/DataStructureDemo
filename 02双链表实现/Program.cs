using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02双链表实现
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDoubleLinkedList<int> list = new MyDoubleLinkedList<int>();
            list.AddAfter(0);
            list.AddAfter(1);
            list.AddAfter(2);
            list.AddAfter(3);
            list.AddBefore(5);
            list.AddBefore(4);
            Console.WriteLine("The Item in the list");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i]+"  ");
            }
            Console.WriteLine("\n------------------------------------------");
            list.InsertAfter(0,6);
            list.InsertBefore(0, 7);
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + "  ");
            }
            Console.WriteLine("\n------------------------------------------");
            list.InsertAfter(2, 8);
            list.InsertBefore(2, 9);
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + "  ");
            }
            Console.WriteLine("\n------------------------------------------");
            list.RemoveAt(2);
            list.RemoveAt(0);
            list[0] = 99999;
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + "  ");
            }
            Console.WriteLine("\n------------------------------------------");
            Console.ReadKey();
        }
    }
}
