using Day15BinarySearchTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Binary Search Tree");
            BinarySearchTree<int> binarySearchTree = new BinarySearchTree<int>(56);

            binarySearchTree.Insert(30);
            binarySearchTree.Insert(70);

            binarySearchTree.Display();
            binarySearchTree.GetSize();

        }

    }
}
