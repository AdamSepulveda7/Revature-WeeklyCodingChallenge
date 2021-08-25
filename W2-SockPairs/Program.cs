using System;
using System.Collections.Generic;

namespace W2_SockPairs
{
    class Program
    {
        static int SockPairs(string str)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();
            int pairs = 0;

            foreach(char ch in str)
            {
                if(!map.ContainsKey(ch))
                {
                    map.Add(ch,1);
                }
                else if(map.ContainsKey(ch))
                {
                    map.Remove(ch);
                    pairs++;
                }
            }

            Console.WriteLine(pairs);

            return pairs;
        }

        static void Main(string[] args)
        {
            SockPairs("AA");
            SockPairs("ABABC");
            SockPairs("CABBACCC");
        }
    }
}
