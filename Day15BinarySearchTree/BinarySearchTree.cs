using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15BinarySearchTree
{
    public class BinarySearchTree<T> where T : IComparable<T>
    {
        public T NodeData { get; set; }
        public BinarySearchTree<T> LeftTree { get; set; }
        public BinarySearchTree<T> RightTree { get; set; }
        public BinarySearchTree(T nodeData)
        {
            this.NodeData = nodeData;
            this.LeftTree = null;
            this.RightTree = null;
        }
        int LeftCount = 0, RightCount = 0;
        bool result = false;
        public void Insert(T item)
        {
            T CurrentNodeValue = this.NodeData;

            if ((CurrentNodeValue.CompareTo(item)) == 0)
            {
                if (this.LeftTree == null)
                {
                    this.LeftTree = new BinarySearchTree<T>(item);
                }
                else
                {
                    this.LeftTree.Insert(item);
                }
            }



            else
            {
                if (this.RightTree == null)
                    this.RightTree = new BinarySearchTree<T>(item);
                else
                {
                    this.RightTree.Insert(item);
                }
            }
        }
        public void Display()
        {
            if (this.LeftTree != null)
            {
                this.LeftCount++;
                this.LeftTree.Display();
            }
            Console.WriteLine(this.NodeData.ToString());
            if (this.RightTree != null)
            {
                this.RightCount++;
                this.RightTree.Display();
            }
        }
        public void GetSize()
        {
            Console.WriteLine("Size" + " " + (1 + this.LeftCount + this.RightCount));
        }
        public bool IfExists(T element, BinarySearchTree<T> node)
        {
            if (node == null)
            {
                return false;
            }
            if (node.NodeData.Equals(element))
            {
                Console.WriteLine("Found the Element in BST" + " " + node.NodeData);
                return true;
            }
            else
            {
                Console.WriteLine("Current element is {0} in BST ", node.NodeData);

            }
            if (element.CompareTo(node.NodeData) < 0)
            {
                IfExists(element, node.LeftTree);

            }
            if (element.CompareTo(node.NodeData) > 0)
            {
                IfExists(element, node.RightTree);
            }
            return result;
        }
    }
}


