using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ChallengesWithTestsMarkVII
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)         
        {
            int divisor = startNumber / n;
            if (n >= startNumber)
            {
                return n;

            }
            else
            {
                return n * (divisor + 1);
            }
        }    

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        { 
            foreach (Business b in businesses)
            {
                if( b.TotalRevenue == 0)
                {
                     b.Name = "CLOSED";
                }
            }
            
        }

        public bool IsAscendingOrder(int[] numbers)
        { if (numbers == null || numbers.Length == 0)
            {
                return false;
            }
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] > numbers[i])
                {
                    return false;
                }
            }
            return true;
        }
    

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            int SumOfEvens = 0;
            if(numbers == null)
            {
                return 0;
            }

            for (int i = 1; i < numbers.Length; i++)
            {
                if(numbers[i -1] %2 == 0)
                {
                    SumOfEvens += numbers[i];
                }
            }
            return SumOfEvens; 
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0)
            {
                return "";
            }

            string newSentence = "";
            int i = 0;

            for (i = 0; i < words.Length - 1; i++)
            {
                if (words[i] == " ")
                {
                    newSentence += "";
                }

                else
                {
                    newSentence += words[i] + " ";
                }

            }

            newSentence += words[words.Length - 1];
            newSentence = newSentence.Trim();

            if (newSentence.Length == 0)
            {
                return "";
            }
            else
            {
                newSentence += ".";
            }

            return Regex.Replace(newSentence, @"\s+", " ");
        }
    
    

        public double[] GetEveryFourthElement(List<double> elements)
        {
            throw new NotImplementedException();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            throw new NotImplementedException();
        }
    }
}
