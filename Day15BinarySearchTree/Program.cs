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
            binarySearchTree.Insert(22);
            binarySearchTree.Insert(48);
            binarySearchTree.Insert(68);
            binarySearchTree.Insert(95);
            binarySearchTree.Insert(11);
            binarySearchTree.Insert(65);
            binarySearchTree.Insert(3);
            binarySearchTree.Insert(16);
            binarySearchTree.Insert(63);
            binarySearchTree.Insert(67);



            binarySearchTree.Display();
            binarySearchTree.GetSize();
            bool result = binarySearchTree.IfExists(63, binarySearchTree);
            Console.WriteLine(result);
        }

    }

}

