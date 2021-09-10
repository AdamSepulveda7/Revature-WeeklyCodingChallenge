using System;

namespace W4_CSharp
{
    class Program
    {
        static string GiveMeSomething(string str)
        {
            string result = "something " + str;
            System.Console.WriteLine(result);
            return result;
        }
        static void Main(string[] args)
        {
            GiveMeSomething("is better than nothing");

            GiveMeSomething("Bob Jane");

            GiveMeSomething("something");
        }
    }
}
