using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SammaTestApp
{
    class TestStringJoin
    {
        public string TestFunction()
        {
            string[] sammaarry = { "hello", "1", "am", "34" };
            string newarray = String.Join(" ", sammaarry);
            return newarray;
        }
        public string Tsfunction2()
        {
            DateTime waiting = new DateTime(2018, 11, 21, 12, 15, 32);
            string chat = String.Format("message sent at {0:t} on {0:D}", waiting);
            Console.WriteLine("message:{0}", chat);
            Console.ReadKey();

        }



    }
}
