using System;

namespace LeetCode_TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };
            Solution sl = new Solution();
            sl.TwoSum(arr, 4);
            foreach (var item in sl.TwoSum(arr, 4))
            {
                Console.WriteLine(item);
            }
        }
    }
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int[] indexes = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 1; j < nums.Length; j++)
                {
                    if (i != j)
                    {
                        if (nums[i] + nums[j] == target)
                        {
                            indexes[0] = i;
                            indexes[1] = j;
                            break;
                        }
                    }

                }
            }
            return indexes;

        }
    }
}
