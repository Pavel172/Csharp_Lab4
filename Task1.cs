using System;
using System.Runtime.InteropServices;



namespace Task1 
{
    public class Program 
    {
        public class MyMatrix 
        {
            public int[][] matrix { get; set; }
            public MyMatrix(int m, int n, int range_start, int range_end) 
            {
                matrix = new int[m][];
                for(int i = 0; i < m; i++) 
                {
                    matrix[i] = new int[n];
                    for(int j = 0; j < n; j++) 
                    {
                        Random rnd = new Random();
                        matrix[i][j] = rnd.Next(range_start, range_end);
                    }
                }
            }
            public void print() 
            {
                for (int i = 0; i < matrix.Length; i++)
                {
                    Console.WriteLine();
                    for (int j = 0; j < matrix[i].Length; j++)
                    {
                        Console.WriteLine(matrix[i][j]);
                    }
                }
            }
        }
        static void main()
        {
            MyMatrix matrix = new MyMatrix(3, 4, 0, 100);
            matrix.print();
        }
    }
}
