using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartNow
{
    class Sanyuan
    {
        public void PanDuan(int number)
        {
            string result = (number > 10) ? number.ToString() : "Less than or equal to 10";
            Console.WriteLine("Result is : {0}", result);
        }
        
    }

}
