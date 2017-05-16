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
            /*  int[] array = new int[3] { 1, 2, 3 };//先赋值
              for (int i = 0; i < array.Length; i++)
              {
                  Console.WriteLine(array[i]);  //循环遍历打印数组里面的值
              }*/
            #endregion
            #region 练习 
            /*  string[] arr1 = new string[4] { "c语言", "c++", "c#", "java" };
              string[] arr2 = { "c语言", "c++", "c#", "java" };
              string[] arr3 = new string[] { "c语言", "c++", "c#", "java" };*/

            //计算1,2,3,4,5,6,7,8,9,10的和
            /*  int[] arry = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
              int sum = 0;
              for (int i = 0; i < arry.Length; i++)
              {
                  Console.WriteLine(arry[i]);
                  sum = sum + arry[i];
              }
              Console.WriteLine("数组所有元素之和是:{0}",sum);*/

            //输入7名学生成绩,分别求出最高分,最低分,平均分
            /* float[] score = new float[7];
             for (int i = 0; i < score.Length; i++)
             {
                 score[i] = Convert.ToSingle(Console.ReadLine());
             }
             float sum = 0;
             float avg = 0;
             float max = score[0];
             float min = score[0];
             for (int i = 0; i < score.Length; i++)
             {
                 sum = sum + score[i];
                 if (max < score[i])
                 {
                     max = score[i];
                 }
                 if (min > score[i])
                 {
                     min = score[i];
                 }
             }
             avg = sum / score.Length;
             Console.WriteLine("最高分是:{0},最低分是:{1},平均分是:{2}",max,min,avg);
 */

            #endregion


            #region foreach语句来遍历数组
          /*  string[] strArray = new string[3] { "a", "b", "c" };
            foreach (string str in strArray)
            {
                Console.WriteLine(str);
            }*/
            #endregion

            #region 二维数组声明
            /*  int[,] arr1 = new int[2, 3] { { 1, 2, 3 }, { 1, 2, 3 } };
              int[,] arr2 = new int[,] { { 1, 2 }, { 3, 4 } };
              int[,] arr3 = { { 1, 2 }, { 3, 4 } };

              int[,] array = new int[7, 2] { { 1, 90 }, { 2, 82 }, { 3, 100 }, { 4, 51 }, { 5, 60 }, { 6,100}, { 7, 87 } };
              */
            #endregion

            #region foreach二维数组遍历
            /* int[,] numArray = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
             int sum = 0;
             foreach (int item in numArray)
             {
                 sum += item;
                 Console.WriteLine(item);
             }
             Console.WriteLine("二维数组之和:{0}",sum);*/
            #endregion

            #region for循环遍历二维数组
            int[,] numArray = new int[3, 2] { { 1, 2 }, { 4, 5 }, { 7,8} };
            for (int i = 0; i < 3; i++) {//外层控制行
                for (int j = 0; j < 2; j++)//内层控制列
                {
                    Console.WriteLine(numArray[i,j]);
                }
                Console.WriteLine();
            }
            #endregion
        }
    }
}
