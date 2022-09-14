using System;
using System.Collections.Generic;
using System.Text;

namespace study
{
    //回溯 全排列
    class Permute
    {
        IList<IList<int>> res = new List<IList<int>>(); //返回结果
        List<bool> used = new List<bool>(); //已经赋值过的路径
        List<int> track = new List<int>();  //路径

        public IList<IList<int>> Test(int[] nums)
        {
            used = new List<bool>(new bool[nums.Length]);
            BackTrace(nums);
            return res;
        }

        public void BackTrace(int[] nums)
        {
            //已经拿到 全部数字排列 就可以触发结束条件
            if (track.Count == nums.Length)
            {
                //需要重新分配内存空间存储，不能将track引用保存进res
                List<int> temp = new List<int>(track);
                res.Add(temp);
                return;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                //排除不合法的
                if (used[i])
                {
                    //排除已经赋值过的节点
                    continue;
                }

                //做选择
                track.Add(nums[i]);
                used[i] = true;

                //递归
                BackTrace(nums);

                //撤销选择
                used[i] = false;
                track.RemoveAt(track.Count - 1);
            }
        }
    }
}
