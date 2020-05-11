using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archiver
{
    public class Node
    {
        public int Data { get; set; }
        public byte Bit { get; set; }
        public string Symbol { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
        public Node() { }
        public Node(int data, string symbol, byte bit) { Data = data; Symbol = symbol; Bit = bit; }


        
    }

    public class codes
    {
        private Node root { get; set; }

        public codes()
        {
            root = null;
        }

        public void InsRoot(Node node)
        {
            if (root == null)
            {
                root = node;
                return;
            }
            else
            {
                Node newRoot = new Node();

                node.Bit = 0;
                newRoot.Left = node;
                root.Bit = 1;
                newRoot.Right = root;
                root = newRoot;
            }
        }


        private void Out(string rootVal, Node node)
        {
            if (node == null)
                return;

            if (node.Left == null && node.Right == null)
            {
                Console.WriteLine(rootVal + node.Bit+node.Symbol);
                return;
            }

            if (node != root)
                rootVal += node.Bit.ToString();

            Out(rootVal, node.Left);
            Out(rootVal, node.Right);
        }

        public void OutputValue()
        {
            Out("",root);
        }
    }
}
