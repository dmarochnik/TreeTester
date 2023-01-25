using System;
using TreeDataStructures;

namespace TreeTester
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MIN_VAL = 0;
            const int MAX_VAL = 100000;
            const int MAX_NUMBERS_IN_TREE = 100;

            // Seed the random number generator
            var rnd = new Random(DateTime.Now.Millisecond);

            // Create the binary tree
            var binTree = new BinaryTree();

            // Add random numbers to binary tree
            for(int i = 0; i < MAX_NUMBERS_IN_TREE; i++)
            {
                binTree.AddNode(rnd.Next(MIN_VAL, MAX_VAL));
            }

            // Output contents of tree (should be ordered ascending)
            foreach(var val in binTree.TreeToInfix())
            {
                Console.Write(val + ", ");
            }
        }
    }
}
