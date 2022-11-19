using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind
{
    public static class GameMethods
    {
        static readonly Random random = new Random();

        public static List<int> GetNumbers()
        {
            List<int> numbers = new List<int>();
            for (int i = 0; i < 4; i++)
            {
                numbers.Add(random.Next(1, 6));
            }
            return numbers;
        }

        public static List<int> GetNumbersFromUser(string numbers)
        {
            List<int> usersNumbers = new List<int>();
            char[] arr = numbers.ToCharArray();
            foreach (char c in arr)
            {
                usersNumbers.Add(int.Parse(c.ToString()));
            }
            return usersNumbers;
        }

        public static List<char> CompareGuessToAnswer(List<int> numbersUser, List<int> numbersAnswer)
        {
            List<char> answer = new List<char>();
            for (int i = 0; i < numbersUser.Count; i++)
            {
                if (numbersUser[i] == numbersAnswer[i])
                {
                    answer.Add('+');
                }
                else if (numbersAnswer.Contains(numbersUser[i]) && numbersUser[i] != numbersAnswer[i])
                {
                    answer.Add('-');
                }
                else
                {
                    answer.Add(' ');
                }
            }
            answer.Sort();
            return answer;
        }

        public static bool isCorrect(List<char> charList)
        {
            List<char> allCorrect = new List<char>();
            for (int i = 0; i < 4; i++)
            {
                allCorrect.Add('+');
            }

            bool isEqual = Enumerable.SequenceEqual(allCorrect, charList);
            if (isEqual)
            {
                return true;
            }

            return false;
        }

        public static bool IsValidNumber(string number)
        {
            if (int.TryParse(number, out int numberInt))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string NumberListString(List<int> numbers)
        {
            string result = "";
            foreach (int number in numbers)
            {
                result = result + number.ToString();
            }
            return result;
        }
    }
}

