using System;

namespace study
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //(1) 深浅复制
            //ShallowDeepCopy.Test();
            //int[] arr = { 4, 5, 6, 7, 0, 1, 2};
            //int aa =  XuanzhuanArray.Search(arr, 2);
            //Console.WriteLine(aa.ToString());

            //Multiply.Test("123","456");

            //Permute permute = new Permute();
            //int[] arr = { 1, 2, 3 };
            //permute.Test(arr);

            //54螺旋矩阵
            //SpiralOrder.Test();

            //59螺旋矩阵2
            //GenerateMatrix.Test();

            ////88合并俩有序数组
            //Merge.Test();

            //[89] 格雷编码
            //GrayCode.Test();

            //215 数组中的第K个最大元素 topk快排
            FindKthLargest.Test();



            Console.ReadLine();
        }
    }
}
