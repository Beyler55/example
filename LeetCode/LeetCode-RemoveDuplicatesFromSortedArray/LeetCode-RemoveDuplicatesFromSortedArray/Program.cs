using System;

namespace LeetCode_RemoveDuplicatesFromSortedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution sl = new Solution();
            int[] nums = { 1, 1, 1, 2, 2, 2, 3, 4, 3, 4, 4}; // Input array
            int[] expectedNums = new int[2]; // The expected answer with correct length    
            Console.WriteLine(sl.RemoveDuplicates(nums));
        }
    }
    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            int count = 0;

            for (int i = 0; i < nums.Length; i++)
            {

                if (i < nums.Length - 1 && nums[i] == nums[i + 1])
                {
                    continue;
                }
                nums[count] = nums[i];
                count++;
            }
            return count;
        }
    }
}
