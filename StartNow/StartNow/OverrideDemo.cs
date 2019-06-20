using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartNow
{
    /// <summary>
    /// abstract
    /// </summary>
    public abstract class OverrideDemo
    {
        public virtual void Show(string s)
        {
            Console.WriteLine($"i am show in father method.{s}");
        }
    }
}
