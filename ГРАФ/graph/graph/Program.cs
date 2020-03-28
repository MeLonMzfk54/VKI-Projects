using System;
using System.Collections.Generic;

namespace graph
{
    class Program
    {
        static void Main(string[] args)
        {
            Tuple<string, string, int>[] tupleArray =
          {
                Tuple.Create("A","B",5),
                Tuple.Create("A","D",9),
                Tuple.Create("B","A",5),
                Tuple.Create("B","E",9),
                Tuple.Create("C","D",7),
                Tuple.Create("C","E",8),
                Tuple.Create("D","A",9),
                Tuple.Create("D","C",7),
                Tuple.Create("D","E",6),
                Tuple.Create("E","B",9),
                Tuple.Create("E","C",8),
                Tuple.Create("E","D",6)
            };
            Graph graph = new Graph();
            HashSet<string> cities1 = graph.allCities(tupleArray);
            Console.WriteLine("Список всех городов: ");
           foreach(var i in cities1)
            {
                Console.Write("\t"+i);
            }
            Console.WriteLine();
            graph.sumRoads(tupleArray);
            graph.closestCities(tupleArray);
            graph.MaxWeight(tupleArray,cities1);
        }
    }
}
