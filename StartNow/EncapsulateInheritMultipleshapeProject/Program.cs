using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulateInheritMultipleshapeProject
{
    abstract public class Pet
    {
        //在基类中初始化
        public Pet(string name)
        {
            _name = name;
        }

        protected string _name;
        public void PrintName()
        {
            Console.WriteLine("Pet name is" + _name);
        }

        abstract public void Speak();
    }

    // 定义一个派生类，其中包含静态方法，静态成员，普通方法
    public class Dog : Pet
    {
        //定义静态成员
        static int Num;

        //定义一个静态方法
        static public void ShowNum()
        {
            Console.WriteLine("Dog count is: " + Num);
        }

        //定义静态构造函数对静态成员进行初始化
        static Dog()
        {
            Num = 0;
        }

        public Dog(string name) : base(name)
        {
            //普通方法可以访问静态成员
            ++Num;
        }
            
        sealed public override void Speak()
        {
            Console.WriteLine(_name + " is speaking" + " Wang!!");
        }
    }
    public class Cat : Pet, ICatchMouse, IClimbTree
    {
        public Cat(string name) : base(name)
        {
        }

        //实现接口的类，在其中声明继承的接口，并在类中实现接口中定义的方法
        public void CatchMouse()
        {
            Console.WriteLine("I can catch mouse");

        }

        public void ClimbTree()
        {
            Console.WriteLine("I can climb tree");

        }

        //通过new关键字，隐藏父类方法
        new public void PrintName()
        {
            Console.WriteLine("Cat name is" + _name);
        }
        public override void Speak()
        {
            Console.WriteLine(_name + " is speaking" + " Miao!!");
        }
    }

    //定义一个静态类，用来扩展方法
    static class PetGuide
    {
        static public void HowToFeedDog(this Dog dog)
        {
            Console.WriteLine("play a vedio about how to feed a dog");
        }
    }

    //定义一个结构
    struct fish
    {
        int weight;
        int size;
        string type;
    }

    //定义一个接口，其中包含一个方法，这个方法是public的但不能声明public
    interface ICatchMouse
    {
        void CatchMouse();
    }

    interface IClimbTree
    {
        void ClimbTree();
    }

    class Program
    {
        static void Main(string[] args)
        {
            Pet[] pets = new Pet[] { new Dog("Wangcai"), new Cat("Xiaoming"), new Dog("xiaoPeng")};

            //也可以使用基类的引用，只能调用基类中的方法
            //Pet dog2 = new Dog("xxx");

            for (int i = 0; i < pets.Length; i++)
            {
                pets[i].Speak();
            }
            Console.ReadKey();
            Cat xiaoming = new Cat("xiaoming");
            ICatchMouse icatchmouse = (ICatchMouse)xiaoming;
            IClimbTree iclimbtree = (IClimbTree)xiaoming;
            //通过对象调用
            xiaoming.CatchMouse();
            xiaoming.ClimbTree();

            //通过接口调用
            icatchmouse.CatchMouse();
            iclimbtree.ClimbTree();
            Console.ReadKey();

            //调用静态方法
            Dog.ShowNum();
            Console.ReadKey();

            //使用静态类扩展的方法
            Dog dog = new Dog("ergouzi");
            dog.HowToFeedDog();
            Console.ReadKey();
        }
    }
}