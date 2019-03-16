using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartNow
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cat babyCat = new Cat();
            //babyCat.Name = "xiaominhg";
            //babyCat.Age = 2;
            //babyCat.Sex = "female";
            ////$是string.format中的新特性
            //string msg = $"I'm a new born baby cat, " +
            //    $"my name is {babyCat.Name}, my age is {babyCat.Age}, " +
            //    $"my sex is {babyCat.Sex}";
            //Console.WriteLine(msg);
            //Console.ReadKey();

            //Console.WriteLine("Please input a number:");
            //Sanyuan sanyuan = new Sanyuan();
            //var input = int.Parse(Console.ReadLine());
            //sanyuan.PanDuan(input);
            const string myName = "Mona";
            const string SBName = "Dennis";
            const string goodName = "Samma";
            string name;
            Console.WriteLine ("What is your name?");
            name = Console.ReadLine();
            switch (name.ToLower())
            {
                case myName:
                    Console.WriteLine("{0}, Your name is same as mine", myName);
                    break;
                case SBName:
                    Console.WriteLine("{0}, this name is too stupid", SBName);
                    break;
                case goodName:
                    Console.WriteLine("{0}, this name is good", goodName);
                    break;
                default:
                    Console.WriteLine("Hi {0}", name);
                    break;

            }
            Console.ReadKey();

        }
    }
}
