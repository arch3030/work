using System;

namespace pascal_triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows,b, i, j;
            int a = 1;
            Console.Write("Insert row : ");
            rows = int.Parse(Console.ReadLine());

            if (rows >= 0)
            {
                for (i = 0; i < rows; i++)
                {
                    for (b = 1; b <= rows - i; b++)
                    {
                        Console.Write(" ");
                    }
                    for (j = 0; j <= i; j++)
                    {
                        if (j == 0 || i == 0)
                        {
                            a = 1;
                        }
                        else
                        {
                            a = a * (i - j + 1) / j;
                            Console.Write(a + " ");
                        }
                    }
                    Console.WriteLine("\n");
                }
            }
            else
            {
                Console.WriteLine("Invalid Pascal's Triangle row number");
            }
            Console.ReadLine();
        }
    }
}
