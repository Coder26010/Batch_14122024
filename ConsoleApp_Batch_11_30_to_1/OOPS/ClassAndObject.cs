using ConsoleApp_Batch_11_30_to_1.OOPS.Polymorphism;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp_Batch_11_30_to_1.OOPS
{
   public class Box
    {
        public int length;
        public int width;
        public int height;

        public static int count;

        public Box()
        {
            length = 1;
            height = 1;
            width = 1;
        }

        public Box(int len,int wid,int hei)
        {
            length = len;
            width = wid;
            height = hei;
        }

        public Box(Box box)
        {
            length = box.length;
            width = box.width;
            height = box.height;
        }

        static Box()
        {
            count = 10;
        }

        public override string ToString()
        {
            return string.Format($"Length : {length} Width : {width} Height : {height}");
        }
    }


    internal class ClassAndObject
    {
        static void Main(string[] args)
        {

            Box box = new Box(10, 10, 5);
            Console.WriteLine(box.ToString());
            //Console.WriteLine($"Height : {box.height}  Width : {box.width}  Length : {box.length}");


            //Box clonebox = new Box(box);

            //box.height = 2000;


            ////Thread.Sleep(2000);
            //Console.WriteLine($"Height : {clonebox.height}  Width : {clonebox.width}  Length : {clonebox.length}");


            //Console.WriteLine("Total Box : " + Box.count);


        }
    }
}
