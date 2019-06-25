using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07给定一个跟节点_判断该二叉树的深度
{
    public class BinaryTreeNode
    {
        public  int Data { get; set; }

        public  BinaryTreeNode LeftChild { get; set; }

        public BinaryTreeNode RightChild { get; set; }

        public BinaryTreeNode(int data)
        {
            Data = data;
        }

        public BinaryTreeNode(int data,BinaryTreeNode leftNode,BinaryTreeNode rightNode)
        {
            Data = data;
            LeftChild = leftNode;
            RightChild = rightNode;
        }



    }
}
