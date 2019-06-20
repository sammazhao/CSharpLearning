using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartNow
{
    class CatOld
    {
        private string name;
        private int age;
        private string sex;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Age //get访问器get到并返回该字段age的值。set访问器给这个字段赋值
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public string Sex
        {
            get { return this.sex; }
            set { this.sex = value; }
        }
    }
}
