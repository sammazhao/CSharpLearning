using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartNow
{
    enum LunchType:byte
    {
        pizza = 1,
        hamburger = 2,
        beef = 3,
        noodle = 4,
        salad = 5,
        sushi = 6
    }
    //public class testPractice
    //{
    //    public enum LunchType
    //    {
    //        pizza=1,
    //        hamburger=2,
    //        beef=3,
    //        noodle=4,
    //        salad=5,
    //        sushi=6
    //    }
    //public bool TestNumInput()
    //{
    //    Console.WriteLine("Please input number1");
    //    int num1 = Convert.ToInt32(Console.ReadLine());
    //    Console.WriteLine("Please input number2");
    //    int num2 = Convert.ToInt32(Console.ReadLine());
    //    while(num1 <= 10)
    //    if (num1 > 10)
    //    {
    //        if (num2 <= 10)
    //        {
    //            Console.WriteLine("The numbers you input are {0}, {1}", num1, num2);
    //            return true;
    //            break;
    //        }
    //        else
    //        {
    //            return false;
    //        }
    //    }
    //    else
    //    {
    //        Console.WriteLine("The numbers you input are {0}, {1}", num1, num2);
    //    }

    //    while ()
    //}

    public enum OrderStatus
    {
        invalid=0,
        askprice=1,
        placeorder=2,
        payment=3,
        ordercancal=101,
        ordercomplete=102,
    }

    public enum Sex
    {
        Male=0,
        Female=1
    }

    

}

