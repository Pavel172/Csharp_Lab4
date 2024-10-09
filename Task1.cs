using System;



namespace Task1
{
    public class Program
    {
        public class MyMatrix
        {
            public double[][] matrix { get; set; }

            public double this[int m, int n] 
            {
                get
                {
                    return matrix[m][n];
                }
                set
                {
                    matrix[m][n] = value;
                }
            }

            public MyMatrix(int m, int n, int range_start, int range_end, Random rnd)
            {
                matrix = new double[m][];
                for (int i = 0; i < m; ++i)
                {
                    matrix[i] = new double[n];
                    for (int j = 0; j < n; ++j)
                    {
                        matrix[i][j] = rnd.Next(range_start, range_end);
                    }
                }
            }

            public static MyMatrix operator +(MyMatrix m1, MyMatrix m2)
            {
                Random rnd = new Random();
                MyMatrix m3 = new MyMatrix(4, 4, 0, 0, rnd);
                for (int i = 0; i < m1.matrix.Length; ++i)
                {
                    for (int j = 0; j < m1.matrix[i].Length; j++)
                    {
                        m3.matrix[i][j] = m1.matrix[i][j] + m2.matrix[i][j];
                    }
                }
                return m3;
            }

            public static MyMatrix operator -(MyMatrix m1, MyMatrix m2)
            {
                Random rnd = new Random();
                MyMatrix m3 = new MyMatrix(4, 4, 0, 0, rnd);
                for (int i = 0; i < m1.matrix.Length; ++i)
                {
                    for (int j = 0; j < m1.matrix[i].Length; j++)
                    {
                        m3.matrix[i][j] = m1.matrix[i][j] - m2.matrix[i][j];
                    }
                }
                return m3;
            }
            public static MyMatrix operator *(MyMatrix m1, MyMatrix m2)
            {
                Random rnd = new Random();
                MyMatrix m3 = new MyMatrix(4, 4, 0, 0, rnd);
                for (int i = 0; i < m1.matrix.Length; ++i)
                {
                    for (int j = 0; j < m2.matrix[i].Length; ++j)
                    {
                        for (int k = 0; k < m2.matrix[i].Length; ++k)
                        {
                            m3.matrix[i][j] += m1.matrix[i][k] * m2.matrix[k][j];
                        }
                    }
                }
                return m3;
            }

            public static MyMatrix operator *(MyMatrix m1, int x)
            {
                Random rnd = new Random();
                MyMatrix m2 = new MyMatrix(4, 4, 0, 0, rnd);
                for (int i = 0; i < m1.matrix.Length; ++i)
                {
                    for (int j = 0; j < m1.matrix[i].Length; j++)
                    {
                        m2.matrix[i][j] = m1.matrix[i][j] * x;
                    }
                }
                return m2;
            }

            public static MyMatrix operator /(MyMatrix m1, int x)
            {
                Random rnd = new Random();
                MyMatrix m2 = new MyMatrix(4, 4, 0, 0, rnd);
                for (int i = 0; i < m1.matrix.Length; ++i)
                {
                    for (int j = 0; j < m1.matrix[i].Length; j++)
                    {
                        m2.matrix[i][j] = m1.matrix[i][j] / x;
                    }
                }
                return m2;
            }

            public void print()
            {
                for (int i = 0; i < matrix.Length; ++i)
                {
                    Console.WriteLine();
                    for (int j = 0; j < matrix[i].Length; j++)
                    {
                        Console.WriteLine(matrix[i][j]);
                    }
                }
                Console.WriteLine("------------------------------------------");
            }
        }
        static void Main()
        {
            Console.WriteLine("Введите нижний предел для случайных чисел:");
            string temp1 = Console.ReadLine();
            int lower_limit = Convert.ToInt32(temp1);
            Console.WriteLine("Введите верхний предел для случайных чисел:");
            string temp2 = Console.ReadLine();
            int upper_limit = Convert.ToInt32(temp2);
            Random random = new Random();
            MyMatrix matrix1 = new MyMatrix(4, 4, lower_limit, upper_limit, random);
            MyMatrix matrix2 = new MyMatrix(4, 4, lower_limit, upper_limit, random);
            MyMatrix matrix3 = matrix1 + matrix2;
            MyMatrix matrix4 = matrix1 - matrix2;
            MyMatrix matrix5 = matrix1 * matrix2;
            MyMatrix matrix6 = matrix1 / 2;
            matrix1[0, 0] = 0;
            matrix1[0, 1] = 0;
            matrix1[0, 2] = 0;
            matrix1[0, 3] = 0;
            matrix1[3, 0] = 0;
            matrix1[3, 1] = 0;
            matrix1[3, 2] = 0;
            matrix1[3, 3] = 0;
            matrix1.print();
        }
    }
}
