using System;


namespace ConsoleApp_Batch_11_30_to_1.CollectionDemo
{
    internal class MultiDimentionArray
    {
        static void Main(string[] args)
        {
            
            int[,] matrixA = new int[3, 2];
            int[,] matrixB = new int[3, 2] { { 10, 20 }, { 30, 40 }, { 50, 60 } };


            for (int r = 0; r < matrixA.GetLength(0); r++)
            {
                for (int c = 0; c < matrixA.GetLength(1); c++)
                {
                    Console.Write($"A[{r},{c}] : ");
                    matrixA[r, c] = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine();
            }
            //Console.WriteLine(_2D.Length);
            //Console.WriteLine(_2D.GetLength(0));
            //Console.WriteLine(_2D.GetLength(1));
            //_2D[0, 0] = 10;

            for (int r = 0; r < matrixA.GetLength(0); r++)
            {
                for (int c = 0; c < matrixA.GetLength(1); c++)
                {
                    int sum = matrixA[r, c] + matrixB[r,c];
                    Console.Write(sum + "\t");
                }

                Console.WriteLine();
            }
        }
    }
}
