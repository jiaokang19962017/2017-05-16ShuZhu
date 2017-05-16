using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 数组的赋值和声明
            /* int[] array = new int[5];//声明一个数组,长度为5
             int[] array1 = new int[5] { 1, 2, 3, 4, 5 };//数组的几种赋值方式
             int[] array2 = new int[] { 1, 2, 3, 4, 5 };
             int[] array3 = { 1, 2, 3, 4, 5 };
             //for循环来为数组赋值
             for (int i = 0; i < array.Length; i++)
             {
                 array[i] = Convert.ToInt32(Console.ReadLine());//给每一个元素赋值
             }*/
            #endregion

            #region 数组取值
            int[] array = new int[3] { 1, 2, 3 };//先赋值
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);  //循环遍历打印数组里面的值
            }
            #endregion


        }
    }
}
