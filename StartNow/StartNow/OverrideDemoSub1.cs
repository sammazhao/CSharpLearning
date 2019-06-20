using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartNow
{
    public class OverrideDemoSub1 : OverrideDemo
    {
        /// <summary>
        /// override 发生在父类和子类之间的， 是纵向的关系
        /// </summary>
        /// <param name="s"></param>
        public override void Show(string s)
        {
            s = $"{s}+++++++++++++++++++++++++{s}";
            base.Show(s);
        }

        /// <summary>
        /// overload 发生在同一个类， 是平行关系
        /// </summary>
        public void Show1()
        {
            Console.WriteLine("this is function of show1.");
        }

        public string Show1(string s)
        {
            Console.WriteLine("this is function of show1 with parameter s.");
            return s;
        }
    }
}
