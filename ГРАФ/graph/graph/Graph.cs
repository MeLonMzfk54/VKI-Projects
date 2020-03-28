using System;
using System.Collections.Generic;
using System.Text;

namespace graph
{
    class Graph
    {
        public HashSet<string> allCities(Tuple<string, string, int>[] tupleArray)
        {
            HashSet<string> cities = new HashSet<string>();
            foreach ( var city in tupleArray)
            {
                cities.Add(city.Item1);
            }
            return cities;
        }

        public void sumRoads(Tuple<string, string, int>[] tupleArray)
        {
            int sum = 0;
            foreach(var i in tupleArray)
            {
                sum += i.Item3;
            }
            Console.WriteLine("Сумма всех дорог: "+ sum);
        }

        public void closestCities(Tuple<string, string, int>[] tupleArray)
        {
            int min = tupleArray[0].Item3;
            foreach(var i in tupleArray)
            {
                if(min >= i.Item3)
                {
                    min = i.Item3;
                }
            }
            foreach(var i in tupleArray)
            {
                if(min == i.Item3)
                {
                    Console.WriteLine("Ближайшие города - " + i.Item1 + " и " + i.Item2);
                }
            }
        }


        public void MaxWeight(Tuple<string, string, int>[] tupleArray, HashSet<string> cities)            
        {
            string s;
            int a = 0;
            int sum = 0;
            int road = 0;
            string сity1 = "";
            string сity2 = "";
            foreach (var k in cities)
            {
                sum = 0;
                s = k;
                for (int i = 0; i < 3; i++)
                {
                    var per = Search(tupleArray, s, a);
                    s = per.Item2;
                    a = per.Item1;
                    sum += per.Item1;
                }
                if (sum > road)
                {
                    road = sum;
                    сity1 = k;
                    сity2 = s;
                }
            }
            Console.WriteLine("Самый длинных путь между " + сity1 + " и " + сity2 + " равен " + sum);
        }

        public (int, string, string) Search(Tuple<string, string, int>[] tupleArray, string city, int c)             
        {
            string str = "";
            int max = 0;
            for (int i = 0; i < 12; i++)
            {
                if (tupleArray[i].Item1 == city)
                {
                    if (tupleArray[i].Item3 > max && tupleArray[i].Item3 != c)
                    {
                        str = tupleArray[i].Item2;
                        max = tupleArray[i].Item3;
                    }
                }
            }
            return (max, str, city);
        }
    }
}
