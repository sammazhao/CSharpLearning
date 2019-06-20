using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartNow
{
    class ClassDemo
    {
    }

    abstract class Animal //抽象类，只能继承，不能实例化，没有构造函数
    {
        public void Running()
        {
            Console.WriteLine($"I can run!!");
        }

        public int age;
        public Sex sex;
    }

    class Dog : Animal
    {
    }
}
