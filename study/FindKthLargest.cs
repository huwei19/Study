using System;
using System.Collections.Generic;
using System.Text;

//215 数组中的第K个最大元素 topk快排
namespace study
{
    internal class FindKthLargest
    {
        public static void Test()
        {
            int[] nums = { 2,1 };
            int k = 1;

            FindKthLargest obj = new FindKthLargest();
            obj.FindKthLargest1(nums, k);
        }

        //topk 推排序、快速排序取前K个 , 数据量大就选用堆排序O(nLogk)、数据量小就用快速排序(O(n))
        public int FindKthLargest1(int[] nums, int k)
        {
            //特殊情况处理
            if (nums.Length < k)
            {
                return int.MinValue;
            }
            if (nums.Length == 1)
            {
                return nums[0];
            }

            int left = 0;
            int right = nums.Length - 1;

            int res = QuickSort(nums, left, right, k);

            return res;
        }

        //快排
        public int QuickSort(int[] nums, int left, int right, int k)
        {
            //快排一次，并取出分界点索引
            int div = Partition(nums, left, right);

            //分界点值 与 k比较大小
            if (div > k - 1)
            {
                //仅需要将分界点前面的数组 再次进行一次 快排
                return QuickSort(nums, left, div, k);
            }
            else if (div < k - 1)
            {
                //仅需要将分界点后面的数组 再次进行一次 快排
                return QuickSort(nums, div + 1, right, k);
            }
            else
            {
                return nums[div];
            }
        }


        //快排一次数组 并取出分界点索引
        public int Partition(int[] nums, int left, int right)
        {
            //霍尔排序
            int key = left;
            int p = left;
            int q = right;
            //p向右移动(寻找小值，停止等待交换)； q向左移动(寻找大值，停止等待交换)；
            while (p < q)
            {
                //right先走
                while (p < q && nums[q] <= nums[key])
                {
                    q--;
                }
                while (p < q && nums[p] > nums[key])
                {
                    p++;
                }

                //左右都找到想寻找到的值 就交换
                if (p < q)
                {
                    Swap(nums, p, q);
                }
            }

            //把哨兵key与相遇位置互换
            int meet = p;
            Swap(nums, meet, key);
            return meet;
        }

        //交换
        public void Swap(int[] nums, int a, int b)
        {
            int temp = nums[b];
            nums[b] = nums[a];
            nums[a] = temp;
        }
    }
}
