using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SammaTestApp
{
    class Program 
    {
        static void Main(string[] args)
        {
            try
            {
                //ArrayListDemo testArray = new ArrayListDemo();
                //string final = testArray.GetArrayString();
                //int final2 = testArray.GetIndexObject();
                //Console.WriteLine("result is: {0}, index of array is {1}", final, final2);
                //Console.ReadKey();
                TestStringJoin teststringjoin = new TestStringJoin();
                //string a =teststringjoin.TestFunction();
                //Console.WriteLine("result is: {0}", a);
                //Console.ReadKey();
                string b = teststringjoin.Tsfunction2();


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

}