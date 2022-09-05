using System;
using System.Collections.Generic;
using System.Text;

namespace study
{
    class XuanzhuanArray
    {
        public static int Search(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;
            int mid = 0;

            //todo nums 个数校验
            while (left <= right)
            {
                mid = (left + right + 1) / 2;
                if (nums[mid] == target)
                {
                    return mid;
                }
                if (nums[left] == target)
                {
                    return left;
                }

                if (nums[left] < nums[mid])
                {
                    if (nums[left] < target && target < nums[mid])
                    {
                        right = mid;
                    }
                    else
                    {
                        left = mid;
                    }
                }
                else if (nums[left] == nums[mid])
                {
                    left++;
                }
                else
                {
                    //nums[left] > nums[mid]
                    if (nums[mid] < target && target < nums[left])
                    {
                        left = mid;
                    }
                    else
                    {
                        right = mid;
                    }
                }
                //a. target num[left]
                //b. target num[lefy]
            }
            return -1;
        }

    }
}
