namespace LeetCode_RotateArray
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Explanation
            //The basic idea is that, for example, nums = [1, 2, 3, 4, 5, 6, 7] and k = 3, first we reverse[1, 2, 3, 4],
            //it becomes[4, 3, 2, 1]; then we reverse[5, 6, 7], it becomes[7, 6, 5], finally we reverse the array as a
            //whole, it becomes[4, 3, 2, 1, 7, 6, 5] ---> [5, 6, 7, 1, 2, 3, 4].
            //Reverse is done by using two pointers, one point at the head and the other point at the tail, after switch
            //these two, these two pointers move one position towards the middle.
            #endregion

            Solution sl = new Solution();
            int[] nums = { 1, 2, 3, 4, 5, 6, 7 };
            int k = 3;
            sl.Rotate(nums, k);
        }
    }
    public class Solution
    {
        public void Rotate(int[] nums, int k)
        {
            int l = nums.Length;
            int[] newnums = new int[nums.Length];
            for (int i = 0; i < k; i++)
            {
                newnums[i] = nums[l - k];
                l += 1;
            }
            int index = 0;
            for (int j = k; j < nums.Length; j++)
            {
                
                if (index < l - k)
                {
                    newnums[j] = nums[index];
                    index++;
                }

            }
            foreach (var item in newnums)
            {
                System.Console.Write(item);
            }

        }
    }
}
