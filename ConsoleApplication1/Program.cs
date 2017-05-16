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
            /*  int[,] numArray = new int[3, 2] { { 1, 2 }, { 4, 5 }, { 7,8} };
              for (int i = 0; i < 3; i++) {//外层控制行
                  for (int j = 0; j < 2; j++)//内层控制列
                  {
                      Console.WriteLine(numArray[i,j]+" ");
                  }
                  Console.WriteLine();
              }*/

            /*   int[,] numArray = new int[3, 2] { { 1, 2 }, { 4, 5 }, { 7,8} };
                  for (int i = 0; i < numArray.GetLength(0); i++) {//外层控制行
                      for (int j = 0; j < numArray.GetLength(1); j++)//内层控制列
                      {
                          Console.WriteLine(numArray[i,j]+" ");
                      }
                      Console.WriteLine();
                  }*/
            #endregion

            #region 酒店练习
            /*  int[,] room = new int[3, 4] { { 101, 102, 103, 104 }, { 201, 202, 203, 204 }, { 301, 302, 303, 304 } };
              /*for (int i = 0; i < room.GetLength(0); i++)
              {
                  Console.WriteLine("{0}",i+1);
                  for(int j = 0; j< room.GetLength(1); j++)
                  {
                      Console.WriteLine(room[i,j]);
                  }
              }*/
            /*  foreach (int item in room)
              {
                  Console.WriteLine(item);
              }*/

            #endregion

            #region 交错数组
            /*   int[][] arry = new int[4][];
               arry[0] = new int[] { 1,,3,5,7,9};
               arry[1] = new int[] { 0,2};
               arry[2] = new int[] { 5,11,26};
               arry[3] = new int[] { 91,3,56,67,32};
               //以上只是初始化
             /*  arry[0][0] = 1;//第一行的第一个
               arry[0][1] = 2;//第一行的第二个
               arry[0][2] = 3;

               arry[3][2] = 3;//第4行第3个*/
            #endregion

            #region 交错数组遍历

            int[][] arry = new int[2][];
            arry[0] = new int[]{ 1,2};
            arry[1] = new int[] { 3, 4,5 };

            int index = 0;
            foreach (int[] arry1 in arry)
            {
                index++;
                Console.WriteLine("第{0}个数组",index);
                foreach (int  item in arry1)
                {
                    Console.WriteLine(item+" ");
                }
            }
            #endregion
        }
    }
}
