using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Alog_LinkedList
{
    public class LinkedList
    {
        public LinkedList(int number)
        {
            this.HeadNode = new Node(number);
        }

        public LinkedList(IEnumerable<int> numbers)
        {
            if (numbers.Count() == 0)
            {
                Console.WriteLine("Empty range!!");
                return;
            }

            int count = 0;
            foreach(var num in numbers)
            {
                if (count == 0)
                    this.HeadNode = new Node(num);
                else
                    this.AddNode(num);
                count++;
            }
        }

        public Node HeadNode { get; set; }

        public void AddNode(int number)
        {
            Node newNode = new Node(number);
            if (this.HeadNode == null)
            {
                this.HeadNode = newNode;
                return;
            }

            if (this.HeadNode.Number > number)
            {
                Node temp = this.HeadNode;
                this.HeadNode = newNode;
                this.HeadNode.NextNode = temp;
            }
            else
            {
                Node node = this.HeadNode;
                while (node.NextNode != null && node.NextNode.Number < number)
                {
                    node = node.NextNode;
                }

                Node temp = node.NextNode;

                node.NextNode = newNode;
                newNode.NextNode = temp;
            }
        }

        public void DeleteNode(int number)
        {
            bool isDeleted = false;

            if (this.HeadNode.Number == number)
            {
                this.HeadNode = this.HeadNode.NextNode;
                isDeleted = true;
            }
            else
            {
                //Node node = this.HeadNode;
                //do
                //{
                //    node = node.NextNode;
                //} while (node.NextNode != null && node.NextNode.Number != number);

                //if (node.NextNode == null)
                //{
                //    Console.WriteLine("Requested number doesn't exist in linked list" + Environment.NewLine);
                //    return;
                //}

                //node.NextNode = node.NextNode.NextNode;
                //Console.WriteLine("Node deleted");

                isDeleted = this.DeleteNode(this.HeadNode, number);
            }
            
            if (isDeleted) Console.WriteLine("Number Deleted");
            else Console.WriteLine("Number not found");
        }

        private bool DeleteNode(Node currentNode, int number)
        {
            if (currentNode == null)
            {
                return false;
            }

            if (currentNode.NextNode != null && currentNode.NextNode.Number == number)
            {
                currentNode.NextNode = currentNode.NextNode.NextNode;
                Console.WriteLine("Node deleted");
                return true;
            }

            return this.DeleteNode(currentNode.NextNode, number);
        }

        public void DeleteLinkedList()
        {
            this.HeadNode = null;

            // in c++ this requires one by one freeing memory
        }

        public int Length()
        {
            int length = 0;
            Node currentNode = this.HeadNode;
            while(currentNode != null)
            {
                length++;
                currentNode = currentNode.NextNode;
            }

            return length;
        }

        /// <summary>
        /// Recursive implementation.
        /// </summary>
        /// <param name="currentNode">Head Node when called for first time.</param>
        /// <returns></returns>
        public int Length(Node currentNode)
        {
            if(currentNode == null)
            {
                return 0;
            }

            return 1 + Length(currentNode.NextNode);
        }

        public bool Exists(int number)
        {
            Node currentNode = this.HeadNode;
            while(currentNode != null)
            {
                if (currentNode.Number == number)
                {
                    return true;
                }

                currentNode = currentNode.NextNode;
            }

            return false;
        }

        /// <summary>
        /// Recursive implementation.
        /// </summary>
        /// <param name="currentNode">Head Node when called for first time.</param>
        /// <param name="number">Number to be searched.</param>
        /// <returns></returns>
        public bool Exists(Node currentNode, int number)
        {
            if (currentNode == null)
            {
                return false;
            }

            if (currentNode.Number == number)
            {
                return true;
            }

            return Exists(currentNode.NextNode, number);
        }

        public int GetNumberAtIndex(int index)
        {
            Node currentNode = this.HeadNode;
            int currentIndex = 0;
            while(currentNode != null)
            {
                if (currentIndex == index)
                {
                    return currentNode.Number;
                }

                currentIndex++;
                currentNode = currentNode.NextNode;
            }

            throw new IndexOutOfRangeException();
        }

        public void PrintLinkedList()
        {
            Node node = this.HeadNode;
            while (node != null)
            {
                Console.WriteLine(node.Number);
                node = node.NextNode;
            }
        }
    }
}
