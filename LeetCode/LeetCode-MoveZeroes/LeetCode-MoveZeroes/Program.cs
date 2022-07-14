using System;
namespace LeetCode_MoveZeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 0, 1, 0, 3, 12 };
            Solution.MoveZeroes(nums);
        }
    }
    public class Solution
    {
        public static void MoveZeroes(int[] nums)
        {
            
            int i = 0, j = 0;
            while (j < nums.Length)
            {
                if (nums[j] == 0)
                {
                    j++;
                }
                else
                {
                    int temp = nums[j];
                    nums[j] = nums[i];
                    nums[i] = temp;
                    i++;
                    j++;
                }
            }
            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }
        }
    }
}
