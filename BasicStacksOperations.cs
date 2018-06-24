using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicStackOperation
{
    class BasicStacksOperations
    {
        static void Main(string[] args)
        {
            string[] operationIntegers = Console.ReadLine().Split(' ');
            var numbersToPush = int.Parse(operationIntegers[0]);
            var numbersToPop = int.Parse(operationIntegers[1]);
            var numberToMatch = int.Parse(operationIntegers[2]);

            string[] numbers = Console.ReadLine().Split(' ');

            var fillStack = GetFilledStack(numbers, numbersToPush);
            var PopNumbersStack = GetPoppedStack(fillStack, numbersToPop);
            PrintMatch(PopNumbersStack, numberToMatch);
                     
        }

        private static void PrintMatch(Stack<int> popNumbersStack, int numberToMatch)
        {
            if (popNumbersStack.Contains(numberToMatch))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(popNumbersStack.Min());
            }
        }

        private static Stack<int> GetPoppedStack(Stack<int> fillStack, int numbersToPop)
        {
            for (int i = 0; i < numbersToPop; i++)
            {
                fillStack.Pop();
            }

            return fillStack;
        }

        private static Stack<int> GetFilledStack(string[] numbers, int numbersToPush)
        {
            var tempStack = new Stack<int>();

            for (int i = 0; i < numbersToPush; i++)
            {
                tempStack.Push(int.Parse(numbers[i]));
            }

            return tempStack;
        }
    }
}
