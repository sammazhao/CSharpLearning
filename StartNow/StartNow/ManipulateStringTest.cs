using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartNow
{
    class ManipulateStringTest
    {
        public void ManiTestLoopString()//遍历循环字符串(字符数组)中的每个字符
        {
            string mystr1 = "This is to test foreach function in string";
            //char[] mychar = mystr1.ToCharArray();
            foreach (char s in mystr1)
            {
                Console.WriteLine($"{s}");
            }
            //输出字符串中字符个数
            Console.WriteLine($"{mystr1.Length}");

            //将字符串中所有字符都小写，并未改变原来字符串
            Console.WriteLine($"{mystr1.ToLower()}");

            //删除字符串前后的空格
            string strWithSpace = " Ha Ha    ";
            Console.WriteLine($"{strWithSpace.Trim()}");

            //删除字符串前后的指定字符
            string inpputStr = ",MY name is Mona,-";
            char[] trimChars = {' ', ',', '-'};
            string result = inpputStr.ToLower().Trim(trimChars);
            Console.WriteLine($"String after manipulation: {result}");

            //左右对齐
            List<string> numList = new List<string> {"23","23453244", "1", "234"};
            foreach (string s in numList)
            {
                Console.WriteLine($"{s.PadLeft(10)}");
            }
            Console.ReadKey();



        }
    }
}
