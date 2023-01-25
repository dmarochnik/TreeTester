using System;
using System.Collections.Generic;

namespace TreeDataStructures
{
    public class Node
    {
        public int Val { get; set; }
        public int Left { get; set; }
        public int Right { get; set; }
    }

    public class BinaryTree
    {
        public Node Root { get; set; }

        public void AddNode(int val)
        {

        }

        public List<int> TreeToInfix()
        {
            List<int> l = new List<int>();
            TraverseInfix(l, Root);
            return l;
        }

        private void TraverseInfix(List<int> list, Node root)
        {

        }
    }
}
