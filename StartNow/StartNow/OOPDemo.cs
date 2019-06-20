using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartNow
{
    class OOPDemo
    {
        //理解对象：对象时OOP应用程序的一个构件，这个构件封装了部分应用程序，可以是一个过程，一些数据或一些更抽象的实体
        //类和对象：对象的类型是类。可以使用类的定义来实例化对象。类的实例=对象
        //属性和字段：属性不能直接访问 private。通常将字段设为私有，通过公共属性访问他。公共属性禁止外部用户访问这些数据

        //构造函数：每个类定义都至少有一个构造函数，默认的构造函数没有参数，与类名相同。也可以类定义包含参数的构造函数
        //静态构造函数：一个类只有一个，不能有访问修饰符，不带任何参数，不能直接调用。
        //只有在1.创建包含静态构造函数的类实例时。2. 访问白喊静态构造函数的类的静态成员时。会先调用静态构造
        //析构函数：清理对象。

        //静态成员：静态属性，方法---全局对象，使用静态成员时，不需要实例化对象。 如 Console.writeline()

        ///////////////////////////面向对象技术包含内容////////////////////////////////////////
        //1. 接口
        //2. 继承 派生类可以访问基类的public, protected,不能访问private。 外部类只能访问public。
        // sealed类：不能用作基类，没有派生类。
        //3. 多态性
        //引用类型和值类型区别： 值类型总是包含一个值，引用类型可以为null。创建的每个类都是引用类型

        //class修饰符： 
        //默认： internal - 只能当前项目中代码访问。public - 其他项目中代码也可以访问。abstract - 不能实例化，只能继承，可以有抽象成员
        // sealed - 不能继承
        //类中定义指定继承： 
        //1. 继承基类： public class MyClass : MyBase。 类定义中只能有一个基类。派生类的可访问性不能高于基类。所以下述代码错误： 
        // internal class ClassFather 
        // public class ClassChild : ClassFather

        //2. 继承接口 eg: public class MyClass : IMyInterface
        // 支持该接口的类必须实现所有接口成员，如果不想使用给定的接口成员，可以提供空的方式即代码为空来实现。
        // 顺序：冒号后先基类，后接口，可以有多个接口
        // public class MyClass : MyBase, IMyInterface1, IMyInterface2

    }

    public abstract class MyBase { } // 抽象类，只能继承，不能实例化
    public interface IMyBaseInterface { }
    internal interface IMyBaseInterface2 { }
    internal interface IMyInterface : IMyBaseInterface, IMyBaseInterface2 { }
    internal sealed class MyComplexClass : MyBase, IMyBaseInterface { } // sealed类，不能继承

    //构造函数
    internal class Cat
    {
        //默认构造函数
        public Cat()
        {

        }

        //非默认构造函数
        public Cat(string type)
        {
            Console.WriteLine($"Cat of type: {type}");
        }
    }

    //析构函数。 当进行垃圾回收时，执行析构函数中的代码，释放资源
    class MyClassNew
    {
        ~MyClassNew()
        {
        }
    }

    // 实例化派生类时，先实例化基类。
    //构造函数执行顺序。 发生构造函数调用错误通常是因为类继承结构中某个基类没有正确实例化，或没有正确的给基类构造函数提供信息。
    public class MyBaseClass
    {
        public MyBaseClass()
        { }

        public MyBaseClass(int i) { }

    }
}
