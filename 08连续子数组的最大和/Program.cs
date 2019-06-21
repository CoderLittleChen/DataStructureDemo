using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08连续子数组的最大和
{
    class Program
    {
        static void Main(string[] args)
        {
            //连续子集最大和
            //和最大的子数组为  {3,10,-4,7,2}   输出和为18
            //{1,2,3,4}  子数组  1 2  3  4  1,2   1,3  1,4  2,3  2,4  3,4   1,2,3  1,2,4  1,3,4    2,3,4   1,2,3,4
            //一个长度为n的数组，共有n(n+1)/2个连续子数组   这个是怎么计算的？
            //找出连续自己最大和  并返回  要求时间复杂度是O(n)
            int[] nums = { 1, -2, 3, 10, -4, 7, 2, -5 };
            bool isValidInput = true;
            int greatest = FindGreatestSumOfSubArray(nums, out isValidInput);
            Console.WriteLine(greatest);
            Console.ReadKey();
        }


        /// <summary>
        /// 求连续自己最大和
        /// </summary>
        /// <returns></returns>
        public static int FindGreatestSumOfSubArray(int[] array, out bool isValidInput)
        {
            if (array == null || array.Length == 0)
            {
                isValidInput = false;
                return 0;
            }
            isValidInput = true;
            int currSum = 0;
            int greatestSum = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (currSum <= 0)
                {
                    currSum = array[i];
                }
                else
                {
                    currSum += array[i];
                }
                if (currSum > greatestSum)
                {
                    greatestSum = currSum;
                }
            }
            return greatestSum;


        }

    }
}
