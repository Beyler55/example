using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode_IntersectionOfTwoArrays
{
    class Program
    {
        static void Main(string[] args)
        {





            Solution s = new Solution();
            int[] nums1 = { 1, 2, 2, 1 }, nums2 = { 2, 2 };
            foreach (var item in s.Intersect(nums1, nums2))
            {
                Console.WriteLine(item);
            }
        }
    }
    public class Solution
    {
        public int[] Intersect(int[] nums1, int[] nums2)
        {

            #region Sol
            //    int count = 0;
            //    for (int i = 0; i < p1.Length; i++)
            //    {
            //        for (int j = 0; j < p2.Length; j++)
            //        {
            //            if (p1[i] == p2[j])
            //            {
            //                count++;
            //                break;
            //            }
            //        }
            //    }

            //    int[] result = new int[count];
            //    count = 0;
            //    for (int i = 0; i < p1.Length; i++)
            //    {
            //        for (int j = 0; j < p2.Length; j++)
            //        {
            //            if (p1[i] == p2[j])
            //            {
            //                result[count++] = p1[i];
            //                break;
            //            }
            //        }
            //    }
            //    return result;

            #endregion

            //if (nums1 == null || nums2 == null) { return null; }

            //Array.Sort(nums1);
            //Array.Sort(nums2);

            //int i = 0;
            //int j = 0;

            //IList<int> result = new List<int>();

            //while (i < nums1.Length && j < nums2.Length)
            //{
            //    if (nums1[i] < nums2[j]) { i++; }
            //    else if (nums1[i] > nums2[j]) { j++; }
            //    else { result.Add(nums1[i]); i++; j++; }
            //}

            //return result.ToArray();

            int[] s, b;
            if (nums1.Length > nums2.Length)
            {
                b = nums1;
                s = nums2;
            }
            else
            {
                s = nums1;
                b = nums2;
            }

            List<int> r = new List<int>();

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < b.Length; j++)
                {
                    if (s[i] == b[j])
                    {
                        b[j] = -1;
                        r.Add(s[i]);
                        break;
                    }
                }
            }
            return r.ToArray();
        }
    }
}

