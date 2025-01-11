using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Batch_11_30_to_1.CollectionDemo
{
    internal static class ArrayCustomExtension
    {

        public static string ConvertToString(this int[] ints, char Deliminator)
        {
            string value = string.Empty;

            for (int i = 0; i < ints.Length; i++)
            {
                value += ints[i].ToString() + Deliminator;
            }

            value = value.Remove(value.LastIndexOf(Deliminator), 1);
            return value;
        }
    }
}
