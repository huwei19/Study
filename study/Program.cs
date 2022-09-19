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
            SpiralOrder.Test();

            Console.ReadLine();
        }
    }
}
