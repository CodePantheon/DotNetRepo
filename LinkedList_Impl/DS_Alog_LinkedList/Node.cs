
namespace DS_Alog_LinkedList
{
    public class Node
    {
        public Node(int number)
        {
            this.Number = number;
            this.NextNode = null;
        }

        public int Number { get; set; }

        public Node NextNode { get; set; }
    }
}