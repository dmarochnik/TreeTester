using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using TreeDataStructures;

namespace TestUnitTester
{
    [TestClass]
    public class UnitTest1
    {
        const int MIN_VAL = 0;
        const int MAX_VAL = 100000;
        const int MAX_NUMBERS_IN_TREE = 100;

        [TestMethod]
        public void TestMethod1()
        {
            // Seed the random number generator
            var rnd = new Random(DateTime.Now.Millisecond);

            // Seed the random number generator
            var binTree = new BinaryTree();

            // Add random numbers to binary tree
            for (int i = 0; i < MAX_NUMBERS_IN_TREE; i++)
            {
                binTree.AddNode(rnd.Next(MIN_VAL, MAX_VAL));
            }

            var treeList = binTree.TreeToInfix();
            var prev = treeList.FirstOrDefault();
            var curr = prev;

            // Output contents of tree (should be ordered ascending)
            for (int i = 1; i < treeList.Count; i++)
            {
                curr = treeList[i];
                if (curr < prev)
                {
                    Assert.Fail($"Expected ascending values during iteration: current - {curr} < previous - {prev}");
                }
                prev = curr;
            }
        }
    }
}
