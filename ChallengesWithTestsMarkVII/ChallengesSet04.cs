using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMarkVII
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int total = 0;
            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    total += num;
                }
                else 
                {
                    total -= num;
                }
            }
            return total;
        } 
                

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {

            int length1 = str1.Length;
            int length2 = str2.Length;
            int length3 = str3.Length;
            int length4 = str4.Length;

            List<int> lengthlist = new List<int> { length1, length2, length3, length4 };


            return lengthlist.Min();
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)

        {
            List<int> numbers = new List<int>() { number1, number2, number3, number4 };
            return numbers.Min();
        }
       

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return (sideLength1 + sideLength2 > sideLength3) && (sideLength3 + sideLength2 > sideLength1)
                && (sideLength3 + sideLength1 > sideLength2);
        }

        public bool IsStringANumber(string input)
        {
            throw new NotImplementedException();
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            throw new NotImplementedException();
        }

        public double AverageEvens(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public int Factorial(int number)
        {
            throw new NotImplementedException();
        }
    }
}
