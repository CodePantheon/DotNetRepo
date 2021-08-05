using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DS_Alog_LinkedList
{
    class Program
    {
        static LinkedList linkedList;

        static void Main(string[] args)
        {
            int[] intRange = { 3, 5, 7, 10, 56, 34, 78, 98, 37, 76 };
            linkedList = new LinkedList(intRange);
            linkedList.PrintLinkedList();

            string choice = string.Empty;
            do
            {
                Console.WriteLine("Choose any of option -\n" +
                    "(P)Print /" +
                    "(L)Length of list /" +
                    "(A)Add /" +
                    "(D)DeleteSingleNode /" +
                    "(S)Search number \n" +
                    "(N)Get Nth number (zero based indexing) /" +
                    "(DL)DeleteList /" +
                    "(E)Exit. ");
                choice = Console.ReadLine().ToUpper();
                ProcessChoice(choice);

            } while (choice != "E");
        }

        private static void ProcessChoice(string choice)
        {
            switch(choice)
            {
                case "P":
                    {
                        linkedList.PrintLinkedList();
                        break;
                    }
                case "A":
                    {
                        AddNode();
                        break;
                    }
                case "D":
                    {
                        DeleteNode();
                        break;
                    }
                case "DL":
                    {
                        linkedList.DeleteLinkedList();
                        break;
                    }
                case "L":
                    {
                        Console.WriteLine(linkedList.Length(linkedList.HeadNode));
                        break;
                    }
                case "S":
                    {
                        Console.WriteLine("Search result: " + SearchNumber());
                        break;
                    }
                case "N":
                    {
                        SearchIndex();
                        break;
                    }
                default:
                    Console.WriteLine("Option is not supported");
                    break;
            }
        }

        private static void AddNode()
        {
            Console.WriteLine("Enter number for adding it to linked list.");
            int number = int.Parse(Console.ReadLine());
            linkedList.AddNode(number);
        }
        
        private static void DeleteNode()
        {
            Console.WriteLine("Enter number for deleting it from linked list.");
            int number = int.Parse(Console.ReadLine());
            linkedList.DeleteNode(number);
        }

        private static bool SearchNumber()
        {
            Console.WriteLine("Enter number for searching in linked list.");
            int number = int.Parse(Console.ReadLine());
            return linkedList.Exists(linkedList.HeadNode, number);
        }

        private static void SearchIndex()
        {
            Console.WriteLine("Enter index for searching in linked list.");
            int number = int.Parse(Console.ReadLine());

            try
            {
                int data = linkedList.GetNumberAtIndex(number);
                Console.WriteLine("Result: " + data);
            }
            catch(IndexOutOfRangeException)
            {
                MessageBox.Show("Warning!! Index is out of range.");
            }
        }
    }
}
