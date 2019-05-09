using System;
using System.Collections.Generic;
using System.Linq;
namespace ChallengesWithTestsMarkVII
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
                return true;
            return false;
        }

        public bool CountOfElementsIsEven(string[] vals)

        {
            return vals.Length % 2 == 0;
        }


        public bool IsNumberEven(int number)
        {
            return number % 2 == 0;
        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
            
           
        { 
            if (numbers == null || !numbers.Any())
            {
                return 0;
            }

            return numbers.Max() + numbers.Min();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return Math.Min(str1.Length, str2.Length);
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            int total = 0;
            foreach (int num in numbers)
            {
                total += num;
            }
            return total;
        }    

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }

            int sum = 0;
            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                   sum += num;
                }
            }
            return sum;
    
        }


        public bool IsSumOdd(List<int> numbers)

        {  /*
            if (numbers == null)
            {
                return false;
            }
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            if (sum % 2 != 0)
            {
                return true;
            }
            return false;
           */
           if(numbers == null)
            {
                return false;
            }

           if( numbers.Sum() % 2 != 0)
            {
                return true;
            }
            return false;
        }




        public long CountOfPositiveOddsBelowNumber(long number)

        {
            if (number > 0)
            {
                return number / 2;
            }
            return 0;

        }
    }
}









