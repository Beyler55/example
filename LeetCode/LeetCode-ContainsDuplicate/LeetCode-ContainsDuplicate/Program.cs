using System;

namespace LeetCode_ContainsDuplicate
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution sl = new Solution();
            int[] arr = { 1, 2, 3, 4, 4 };
            Console.WriteLine(sl.ContainsDuplicate(arr));
        }
    }
    public class Solution
    {

        public bool ContainsDuplicate(int[] nums)
        {

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (i != j)
                    {
                        if (nums[i] == nums[j])
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
    }
}
