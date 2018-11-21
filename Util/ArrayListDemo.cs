using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SammaTestApp
{
    class ArrayListDemo
    {
        //private int[] testArray = new int[5] { 2, 4, 7, 6, 8 };
        public static int GetArrayLength(Object[] obj)
        {

            int res = obj.Length;
            return res;
        }


        public static int GetIndexObject(Object[] obj, Object obj2)
        {
            int ret2 = Array.IndexOf(obj, obj2);
            return ret2;
        }

        public static string[] ReturnStringArray(Object[] obj)
        {
            string[] res = new string[obj.Length];
            for (int i = 0; i < obj.Length; i++)
            {
                res[i] = obj[i].ToString();
            }
            return res;
        }

    }
}
