using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6kyuRomanNumeralsEncoder
{
    internal class Program
    {
        static void Main(string[] args)
        {


            var a = 4;
            Console.WriteLine(RomanConvert.Solution(a));
        }
    }
    public class RomanConvert
    {
        public static string Solution(int n)
        {
            int i = 0;
            StringBuilder answer = new StringBuilder();
            do
            {
                if (n - romanNumber.ElementAt(i).Value < 0)
                {
                    i++;

                }
                else if (n.ToString()[0] == '9')
                {
                    answer.Append(romanNumber.ElementAt(i + 1).Key + romanNumber.ElementAt(i - 1).Key);
                    n -= 9 * romanNumber.ElementAt(i + 1).Value;
                    i++;
                }
                else if (n.ToString()[0] == '4')
                {
                    answer.Append(romanNumber.ElementAt(i).Key + romanNumber.ElementAt(i-1).Key);
                    n -= 4 * romanNumber.ElementAt(i).Value;
                    i++;
                }
                else
                {
                    answer.Append(romanNumber.ElementAt(i).Key);
                    n -= romanNumber.ElementAt(i).Value;

                }

            } while (n != 0);
            return answer.ToString();
        }
        private static readonly Dictionary<string, int> romanNumber = new Dictionary<string, int>
        { { "M", 1000 },
          { "D", 500 },
          { "C", 100 },
          { "L", 50 },
          { "X", 10 },
          { "V", 5 },
          { "I", 1 }
        };
    }
}


