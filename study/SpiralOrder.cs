using System;
using System.Collections.Generic;
using System.Text;

namespace study
{
    //54 螺旋矩阵
    internal class SpiralOrder
    {
        public static void Test()
        {
            //int[] pa = { 1, 2 };
            //int[,] param = {
            //    { 1,2,3,4},
            //    { 5,6,7,8},
            //    { 9,10,11,12},
            //};
            int[][] param = new int[][] {
                new int[]{ 1, 2, 3, 4 },
                new int[]{ 5, 6, 7, 8 },
                new int[]{ 9, 10, 11, 12 },
            };

            SpiralOrder1(param);
        }
        public static IList<int> SpiralOrder1(int[][] matrix)
        {
            List<int> res = new List<int>();
            //校验
            if (matrix.Length <= 0 || matrix[0].Length <= 0)
            {
                return res;
            }

            //四个边界up、down、left、right
            //左上角为坐标原点
            int up = 0;
            int down = matrix.Length - 1;
            int left = 0;
            int right = matrix[0].Length - 1;
            while (left <= right && up <= down)
            {
                //往右边++
                for (int i = left; i <= right; i++)
                {
                    int temp = matrix[up][i];
                    res.Add(temp);
                }
                //return res;
                up++;

                //往下边++
                for (int i = up; i <= down; i++)
                {
                    int temp = matrix[i][right];
                    res.Add(temp);
                }
                //return res;
                right--;

                //往左边++ 需要剔除重复添加的数字（已经往右++了，不需要再重复往左++）
                for (int i = right; i >= left && up <= down; i--)
                {
                    int temp = matrix[down][i];
                    res.Add(temp);
                }
                //return res;
                down--;

                //往上边++  需要剔除重复添加的数字（已经往下++了，不需要再重复往上++）
                for (int i = down; i >= up && left <= right; i--)
                {
                    int temp = matrix[i][left];
                    res.Add(temp);
                }
                left++;
            }
            return res;
        }
    }
}
