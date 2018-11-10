using System;
using System.Linq;

namespace _07._Equal_Arrays
{
    class EqualArray
    {
        static void Main(string[] args)
        {
            int[] firstArray = Console.ReadLine()
                .Split().Select(int.Parse).ToArray();

            int[] secondArray = Console.ReadLine()
                .Split().Select(int.Parse).ToArray();

            int sum = 0;

            for (int i = 0; i < firstArray.Length; i++)
            {
                int currentNum = firstArray[i];
                if (firstArray[i] != secondArray[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    return;
                }
                else if (firstArray[i] == secondArray[i])
                {                    
                    sum += currentNum;                                     
                }
            }                
            Console.WriteLine($"Arrays are identical. Sum: {sum}");
        }
    }
}