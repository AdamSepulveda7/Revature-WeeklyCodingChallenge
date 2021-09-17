using System;

namespace W5_ExpressFactor
{
    class Program
    {
        static string ExpressFactors(int num)
        {
            int total = num;
            bool isPrime = true;
            string result = "";
            for (int i = 2; i< total; i++)
            {
                int exp = 0;
                
                while (num % i == 0)
                {
                    isPrime = false;
                    num /= i;
                    exp++;
                }
                if(exp == 1)
                {
                    result += i.ToString();
                }
                else if (exp > 1)
                {
                    result += i.ToString() + "^" + exp.ToString();
                }
                if(num == 1)
                {
                    break;
                }
                else if (num > 1 && exp > 0)
                {
                    result += " x ";
                }
            }
            if(isPrime)
            {
                result = num.ToString();
            }
            Console.WriteLine(result);
            return result;
        }

        static void Main(string[] args)
        {
            ExpressFactors(2);
            ExpressFactors(4);
            ExpressFactors(10);
            ExpressFactors(60);
        }
    }
}
