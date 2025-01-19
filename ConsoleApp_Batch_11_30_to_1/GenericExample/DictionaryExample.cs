using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Batch_11_30_to_1.GenericExample
{
    internal class DictionaryExample
    {
        static void Main(string[] args)
        {
            Dictionary<int,String> dic = new Dictionary<int,String>();

            dic.Add(5, "E");
            dic.Add(1, "A");
            dic.Add(2, "B");
            dic.Add(3, "C");
            dic.Add(4, "D");
            dic.Add(6, "D");

            string searchelement = dic[3];
            Console.WriteLine(searchelement);

            foreach (var item in dic)
            {
                Console.WriteLine(item.Key + " - " + item.Value);
            }
        }
    }
}
