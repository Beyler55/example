using System;

namespace LeetCode_PlusOne
{
    class Program
    {
        static void Main(string[] args)
        {

            Solution sl = new Solution();
            int[] digits = { 1, 2, 3 };
            Console.WriteLine(sl.PlusOne(digits));
        }
    }
    public class Solution
    {
        public int[] PlusOne(int[] digits)
        {

            //int number = 0;
            //for (int i = 0; i < digits.Length; i++)
            //{
            //    number += digits[i] * Convert.ToInt32(Math.Pow(10, digits.Length - i - 1));
            //}
            //number += 1;

            //String temp = number.ToString();
            //int[] newarr = new int[temp.Length];
            //for (int i = 0; i <digits.Length; i++)
            //{
            //    newarr[i] = Convert.ToInt32(temp[i]);
            //}
            //return newarr;

            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (digits[i] < 9)
                {
                    digits[i]++;
                    return digits;
                }
                digits[i] = 0;
            }

            var result = new int[digits.Length + 1];
            result[0] = 1;
            return result;
        }
    }
}
