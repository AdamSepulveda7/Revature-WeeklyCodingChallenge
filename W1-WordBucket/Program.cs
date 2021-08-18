using System;
using System.Collections.Generic;

namespace WordBucket
{
    class Program
    {
         static List<string> bucketize(string str, int numOfChar)
        {
            //string[] result = new string[]{};
            List<string> result = new List<string>();
            str = str.Trim();

            int arrSize = 0;
            int counter = 0;
            string tempWord = "";
            string tempStr = "";

            for(int i = 0; i<str.Length; i++)
            {
                
                //string subStr = str.Substring(0,10);
                //result = subStr.Split();
                if(str[i] == ' ')
                {
                    tempStr += tempWord + " ";
                    tempWord = "";
                }
                else if(str[i]==str.Length-1)
                {
                    System.Console.WriteLine("dsdsdsd");
                }
                else
                {
                    tempWord += str[i];
                }
                
                if(counter==10)
                {
                    //result[arrSize] = tempStr;
                    result.Add(tempStr+' ');
                    tempStr = "";
                    counter=0;
                }
                counter++;
            }
            //result.Add(str);
            //Console.WriteLine(result.);
            foreach(string s in result)
            {
                System.Console.WriteLine(s);
            }
            return result;
        }
        static void Main(string[] args)
        {
            string str = "she sells sea shells by the sea     ";
            int numOfChar = 10;
            bucketize(str, numOfChar); 
            
        }
    }
}
