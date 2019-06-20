using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartNow
{
    public class ArrayDemo
    {
        /// <summary>
        /// Use initialize and define the length of array.
        /// </summary>
        public void TestArrayFuntion()
        {
            int[] numArray = new int[6];
            for (int i=0; i < numArray.Count(); i++)
            {
                Console.WriteLine("The number is {0}", numArray[i]);
            }
        }

        /// <summary>
        /// directly assign values for each element in array. 
        /// </summary>
        public void TestArrayFunction2()
        {
            string[] strArray = { "this", "is", "demo", "for", "array", "" };
            for (int i = 0; i < strArray.Count(); i++)
            {
                Console.WriteLine("Index is: {0}, value is {1}.", i, strArray[i]);
            }

        }

        /// <summary>
        /// Initialize new array object and same time define the length and each elements of this array. 
        /// </summary>
        /// <returns></returns>
        public int[] TestArrayFunction3()
        {
            int[] numArrayNew = new int[5] { 1, 2, 3, 4, 5 };
            Console.WriteLine("The array length is: {0}", numArrayNew.Count());
            return numArrayNew;
        }

        ///////////////多维数组////////////////////
       
        /// <summary>
        /// 1. 矩形数组
        /// </summary>
        public void MultiArray()
        {
            //声明多维数组法1
            int[,] hillHight = { {3,2 }, {1,2 }, {6,7 } };

            //声明多维数组法2
            int[,] hillHight2 = new int[3, 2];

            foreach (int height in hillHight)
            {
                Console.WriteLine("Hill value: {0}", height);
            }
        }

        /// <summary>
        /// 2. 锯齿数组，声明并初始化
        /// </summary>
        public void MultiArray2()
        {
            int[][] tableContentArray = { new int[] { 8, 2, 3 }, new int[] { 999 }, new int[] { 3, 4 } };

            ////需要先循环数组中子数组个数，再循环每个子数组中的元素
            for (int i = 0; i < tableContentArray.Count(); i++)
            {
                Console.WriteLine("Start to traversal Sub array {0}", i + 1);
                foreach (int j in tableContentArray[i])
                {
                    Console.WriteLine("Elements in sub array {0}: {1}", i+1, j);
                }

            }
        }

        /////////字符串处理//////////////////
        //string类型变量可以看做Char变量的只读数组
        public void ManipulateStringTest()
        {
            string testStr = "This is a test string.";
            char[] testChars = testStr.ToCharArray();
            foreach (char i in testChars)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("char array length is: {0}", testChars.Length);
        }


        /// <summary>
        /// 同理还有ToLower
        /// </summary>
        public void ToupperTest()
        {
            Console.WriteLine("Please input yes");
            string userInput = Console.ReadLine();
            if (userInput.ToUpper() == "YES")
            {
                userInput = userInput.ToUpper();
                Console.WriteLine(userInput);
            }

        }

        /// <summary>
        /// trim去除字符串首尾的空格
        /// </summary>
        public void ToTrimTest()
        {
            Console.WriteLine("Please input a string: ");
            string userInput = Console.ReadLine();
            userInput = userInput.Trim();
            Console.WriteLine("what you input is:{0} ", userInput);
        }

    }
}
