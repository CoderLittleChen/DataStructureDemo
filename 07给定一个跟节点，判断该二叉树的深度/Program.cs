using _07给定一个跟节点_判断该二叉树的深度;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07给定一个根节点_判断该二叉树的深度
{
    class Program
    {
        static void Main(string[] args)
        {
            //
        }

        public static int GetTreeDepth(BinaryTreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            int left = GetTreeDepth(root.LeftChild);
            int right = GetTreeDepth(root.RightChild);
            return left >= right ? left + 1 : right + 1;

        }

    }
}
