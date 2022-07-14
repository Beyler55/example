using System;

namespace LeetCode_SingleNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1,1,1,5,4,4};
            Solution sl = new Solution();
            Console.WriteLine(  sl.SingleNumber(num));
        }
    }
    public class Solution
    {
       
        public int SingleNumber(int[] nums)
        {
            int res = nums[0];
            for (int i = 1; i < nums.Length; i++)
                res = res ^ nums[i];
            return res;
        }
       
    }
}
