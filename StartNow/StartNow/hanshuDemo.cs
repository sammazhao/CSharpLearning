using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartNow
{
    class hanshuDemo
    {
        public static string myStr = "this is global string";
        public static int StaticFunction() //静态方法可以不用初始化。
        {
            int para1 = 33;
            Console.WriteLine("This is a static function. No mwwd to initialize a object of this function");
            //当执行到return语句时。程序立即返回嗲用代码，该语句后面的代码都不会再执行。return必须在方法结束}之前加上。
            return para1;
        }

        /// <summary>
        /// 返回一个数组中的最大值
        /// </summary>
        /// <param name="intArray"></param>
        /// <returns></returns>
        public static int MaxValue(int[] intArray)
        {
            int max = intArray[0];
            for (int i = 0; i < intArray.Count(); i++)
            {
                if (intArray[i] > max)
                {
                    max = intArray[i];
                }
            }
            return max;
        }

        /// <summary>
        /// 使用参数数组，关键字params， 可以传入任意个该类型的参数
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static int SumValues(params int[] values)
        {
            int sum = 0;
            foreach (int val in values)
            {
                sum += val;
            }
            return sum;
        }

        public static void showDouble(ref int val)
        {
            val *= 2;
            Console.WriteLine("result is: {0}", val);
        }

        public static void testRef()
        {
            //ref作为局部变量使用
            int val1 = 3;
            ref int val2 = ref val1;
            val2 = 88;
            Console.WriteLine("{0}, {1}", val1, val2);
            Console.ReadKey();
        }

        /// <summary>
        /// ref作为返回值使用
        /// </summary>
        /// <param name="val">parameter</param>
        /// <returns>value</returns>
        public static ref int testRef2(ref int val)
        {
            val *= 2;
            return ref val;
        }

        ///////////////////////////变量作用域/////////////////////////
        
        //定义静态全局变量.
        //Q: 当全局和局部重名，如何使用全局？
        public static void testFun()
        {
            string myStr = "this is defined in testFun";
            Console.WriteLine("Now in testFun string: {0}", myStr);
            Console.WriteLine($"Now in global string: {myStr}");
        }

        //在分支和循环中的变量作用域
        public static void testFun2()
        {
            string text = string.Empty; //使用变量前需要对变量进行声明和初始化，该局部变量可以在循环内外部使用。
            for (int i = 0; i < 5; i++)
            {
                text = $"Line {Convert.ToString(i)}";
            }
            Console.WriteLine($"last output line is: {text}");
        }

        public static void testFun3(int val)
        {
            val *= 2;
            Console.WriteLine($"local -val={val}");
        }

        ///////////////////////////函数重载////////////////////////////////
        //同名函数，每个函数使用不同的参数类型，只有返回值类型不同的不行
    }
}
