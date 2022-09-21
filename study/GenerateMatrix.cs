using System;
using System.Collections.Generic;
using System.Text;

namespace study
{
    //59螺旋矩阵2
    internal class GenerateMatrix
    {
        public static void Test()
        {

            GenerateMatrix1(3);
        }

        public static int[][] GenerateMatrix1(int n)
        {
            //总个数 n*n
            int[,] res = new int[n, n];
            int count = 0;  //个数累积
            int circle = 1; //第N圈
            while (count < n * n)
            {
                //从左往右
                for (int i = circle - 1; i <= n - 1 - (circle - 1); i++)
                {
                    count++;
                    res[circle - 1, i] = count;
                }

                //从上到下
                for (int i = circle; i <= n - 1 - (circle - 1); i++)
                {
                    count++;
                    res[i, n - circle] = count;
                }

                //从右往左
                for (int i = n - 1 - circle; i >= circle - 1; i--)
                {
                    count++;
                    res[n - circle, i] = count;
                }

                //从下往上
                for (int i = n - 1 - circle; i >= circle; i--)
                {
                    count++;
                    res[i, circle - 1] = count;
                }
                circle++;
            }

            int[][] temp = new int[n][];
            for (int i = 0; i < n; i++)
            {
                temp[i] = new int[n];
                for (int j = 0; j < n; j++)
                {
                    temp[i][j] = res[i, j];
                }
            }
            return temp;
        }
    }
}