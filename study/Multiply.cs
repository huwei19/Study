using System;
using System.Collections.Generic;
using System.Text;

namespace study
{
    //字符串相乘

    class Multiply
    {
        public static string Test(string num1, string num2)
        {
            char[] arr_char_1;
            char[] arr_char_2;
            //确保第一个因子arr_1 长度最大
            if (num1.Length >= num2.Length)
            {
                arr_char_1 = num1.ToCharArray();
                arr_char_2 = num2.ToCharArray();
            }
            else
            {
                arr_char_2 = num1.ToCharArray();
                arr_char_1 = num2.ToCharArray();
            }
            int[] arr_1 = new int[arr_char_1.Length];
            int[] arr_2 = new int[arr_char_2.Length];
            //将字符转为数字 -->低位在前 高位在后
            for (int i = 0; i < arr_char_1.Length; i++)
            {
                arr_1[arr_char_1.Length - 1 - i] = arr_char_1[i] - '0';
            }
            for (int i = 0; i < arr_char_2.Length; i++)
            {
                arr_2[arr_char_2.Length - 1 - i] = arr_char_2[i] - '0';
            }

            int[] arr_res = new int[arr_1.Length + arr_2.Length];
            //字符相乘
            for (int i = 0; i < arr_1.Length; i++)
            {
                for (int j = 0; j < arr_2.Length; j++)
                {
                    arr_res[i + j] += arr_1[i] * arr_2[j];
                }
            }
            // return arr_res[0].ToString();
            // return arr_res.Length.ToString();

            //进位数字
            int t = 0;
            //进位  eg  6 0  
            for (int i = 0; i < arr_res.Length; i++)
            {
                int temp = arr_res[i];
                arr_res[i] = temp % 10 + t;
                t = temp / 10;
            }

            //将结果解析为字符串 //去零
            string a = "";
            bool have1Num = false;
            for (int i = arr_res.Length - 1; i >= 0; i--)
            {
                if (arr_res[i] > 0 || have1Num)
                {
                    a = a + arr_res[i];
                    have1Num = true;
                }
            }
            return a;
        }
    }
}
