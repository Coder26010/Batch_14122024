using System;
using System.Collections;


namespace ConsoleApp_Batch_11_30_to_1.CollectionDemo
{
    internal class ArrayListExample
    {
        static void Main(string[] args)
        {

            //int[] A = { 10, 20,"Test"};
            //int n1 = 10;
            //int n2 = 20;
            //object a = n1;//Converting a value type into ref type is callled Boxing
            //object b = n2;

            //int N1 = (int)a;//Converting Ref type into value type is called unboxing
            //int N2 = (int)b;

            //Console.WriteLine(N1 + N2);

            ArrayList arrayList = new ArrayList();

            arrayList.Add(1);
            arrayList.Add(2);
            arrayList.Add(3);
            arrayList.Add(4);
            arrayList.Add(5);
            arrayList.Add(6);
            Console.WriteLine(arrayList.Count);

            for (int i = 7; i < 11; i++)
            {
                arrayList.Add(i);
                arrayList.Add("test");
            }

            Console.WriteLine(arrayList.Count);


            arrayList.RemoveRange(0, 10);
            Console.WriteLine(arrayList.Count);

        }
    }
}
