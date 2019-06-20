using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartNow
{
    public class CaseSwitchDemo
    {
        public void CaseSwitchFunction()
        {
            string[] dayName = { "Mon.", "Tue.", "Sun." };
            foreach (var name in dayName)
            {
                switch (name)
                {
                    case "Mon.":
                        Console.WriteLine("It is {0} today, we should work", name);
                        break;
                    case "Tue.":
                        Console.WriteLine("It is {0} today, we should work", name);
                        break;
                    case "Sun.":
                        Console.WriteLine("It is {0}, we should play and be happy. ", name);
                        break;
                }
            }

        }
    }
}
