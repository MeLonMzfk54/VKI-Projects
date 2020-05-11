using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archiver
{
    class Archiver
    {
        public codes Result;

        public codes GetBinaryTree(Dictionary<string, int> frequencyTable)
        {
            Result = new codes();            

            while (frequencyTable.Count > 1)
            {
                frequencyTable = frequencyTable.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

                KeyValuePair<string, int> value1 = frequencyTable.ElementAt(frequencyTable.Count - 1);
                KeyValuePair<string, int> value2 = frequencyTable.ElementAt(frequencyTable.Count - 2);

                Node node1 = new Node(value1.Value, value1.Key, 1);
                Node node2 = new Node(value2.Value, value2.Key, 0);
                Node root = new Node(value1.Value + value2.Value, value1.Key + value2.Key, (byte)((frequencyTable.Count % 2 == 0) ? 0 : 1));

                root.Left = node2;
                root.Right = node1;
                Result.InsRoot(root);

                frequencyTable.Remove(value1.Key);
                frequencyTable.Remove(value2.Key);
            }

            if (frequencyTable.Count == 1)
            {
                KeyValuePair<string, int> value1 = frequencyTable.ElementAt(frequencyTable.Count - 1);
                Node root = new Node(value1.Value, value1.Key, (byte)((frequencyTable.Count % 2 == 0) ? 0 : 1));
               Result.InsRoot(root);
            }

            return Result;
        }        
    }
}
