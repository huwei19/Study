using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
//[89] 格雷编码（难弄）
namespace study
{
    internal class GrayCode
    {
        public static void Test()
        {
            GrayCode1(1);
        }

        public static IList<int> GrayCode1(int n)
        {
            IList<int> res = new List<int>();

            //动态规划
            //方程式 res[n] = res[n-1]  +     "1" +逆序res[n-1] 

            res.Add(0);

            //特殊情形
            if (n == 0)
            {
                return res;
            }
            
            int first = 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = res.Count - 1; j >= 0; j--) {
                    res.Add(first + res[j]);
                }

                // 左移一位
                first = first << 1; //---> + 2的n次方
            }

            return res;
        }
    }
}
