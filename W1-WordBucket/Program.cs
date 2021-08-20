using System;
using System.Collections.Generic;

namespace WordBucket
{
    class Program
    {
        static List<string> bucketize(string str, int numOfChar)
        {
            List<string> result = new List<string>();
            str = str.Trim();

            int counter = 0;
            string tempWord = "";
            string tempStr = "";

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    tempStr += tempWord + " ";
                    tempWord = "";
                }
                else if (i == str.Length - 1 && str[i - 1] != ' ')
                {
                    tempWord += str[i];
                    tempStr += tempWord + " ";
                    result.Add(tempStr + ' ');
                }
                else if (i == str.Length - 1 && str[i - 1] == ' ')
                {
                    tempWord += str[i];
                    result.Add(tempStr + ' ');
                    tempStr = "";
                    tempStr += tempWord + " ";
                }
                else
                {
                    tempWord += str[i];
                }
                counter++;
                
                if (counter == numOfChar + 1)
                {
                    if(tempWord.Length>numOfChar)
                    {
                        tempWord = "";
                    }
                    result.Add(tempStr + ' ');
                    tempStr = "";
                    counter = tempWord.Length;
                }
            }
            foreach (string s in result)
            {
                System.Console.WriteLine(s);
            }
            return result;
        }
        static void Main(string[] args)
        {
            bucketize("she sells sea shells by the sea", 10);
            bucketize("the mouse jumped over the cheese", 7);
            bucketize("fairy dust coated the air", 20);
            bucketize("a b c d e", 2);

        }
    }
}
