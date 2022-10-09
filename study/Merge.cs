using System;
using System.Collections.Generic;
using System.Text;
//88合并俩有序数组
namespace study
{
    internal class Merge
    {
        public static void Test()
        {

            int[] nums1 = { 1, 2, 3, 0, 0, 0 };
            int m = 3;
            int[] nums2 = { 2, 5, 6 };
            int n = 3;

            Merge1(nums1, m, nums2, n);

            int bb = 1;
        }

        public static void Merge1(int[] nums1, int m, int[] nums2, int n)
        {
            int a = 0;
            int b = 0;
            int[] res = new int[m + n];
            //1 2 3 0 0 ---- 4 5
            for (int i = 0; i < m + n; i++)
            {
                if (a >= m)
                {
                    res[i] = nums2[b];
                    b++;
                    continue;
                }
                if (b >= n)
                {
                    res[i] = nums1[a];
                    a++;
                    continue;
                }

                //结果存储较小的值
                if (nums1[a] <= nums2[b])
                {
                    res[i] = nums1[a];
                    a++;
                }
                else
                {
                    res[i] = nums2[b];
                    b++;
                }
            }

            //重新赋值
            for (int i = 0; i < m + n; i++)
            {
                nums1[i] = res[i];
            }
        }
    }
}
