using System;

namespace _04._Reverse_Array_of_Strings
{
    class ReverseArrayOfStrings
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            for (int i = 0; i < input.Length / 2; i++)
            {
                string firstText = input[i];
                input[i] = input[input.Length - i - 1];
                input[input.Length - i - 1] = firstText;
            }
            Console.WriteLine(string.Join(' ', input));
        }
    }
}