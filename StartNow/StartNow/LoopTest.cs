using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartNow
{
    class LoopTest
    {
        public int DoWhile(int input=1)// do while循环至少会执行一次，因为循环中的布尔测试是在do之后进行的
        {
            do
            {
                Console.WriteLine("{0}", input++);
            }
            while (input <= 10);
            return input;
        }

        public int TestWhile(int input)//while循环的布尔测试时在循环开始时进行的，如果为false，则不会执行循环
        {
            while (input <= 5)
            {
                Console.WriteLine("{0}", input++);
            }
            return input;
        }

        public void TestFor(int input)
        {
            for (input = 1; input <= 10; ++input)
            {
                Console.WriteLine("{0}", input);

            }
        }

        


    }


}
