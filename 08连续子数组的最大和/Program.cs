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
            //int[] nums = { 1, -2, 3, 10, -4, 7, 2, -5 };

            //int[] nums = { -1, -2, 9, -19, 1, -23 };
            int[] nums = null;
            bool isValid = true;
            int greatest = FindGreatestSumOfSubArray(nums, out isValid);
            Console.WriteLine(greatest);
            Console.ReadKey();

        }


        /// <summary>
        /// 求连续子数组最大和
        /// </summary>
        /// <param name="nums"></param>
        public static int FindGreatestSumOfSubArray(int[] nums, out bool isValid)
        {
            if (nums == null || nums.Length == 0)
            {
                isValid = false;
                return 0;
            }
            isValid = true;
            //当前数组元素的和
            int currentSum = 0;
            //当前所有元素的最大和  注意这里赋值的时候  因为数组中可能存在负数  所有不能为0
            int greatestSum = int.MinValue;
            for (int i = 0; i < nums.Length; i++)
            {
                if (currentSum <= 0)
                {
                    currentSum = nums[i];
                }
                else
                {
                    currentSum += nums[i];
                }
                if (currentSum > greatestSum)
                {
                    greatestSum = currentSum;
                }
            }
            return greatestSum;
        }


    }
}
