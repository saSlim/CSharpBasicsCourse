using System;

namespace Pr07.MatrixOfPalindromes
{
    class MatrixOfPalindromes
    {

        //        Problem 7. Matrix of Palindromes
        //Write a program to generate the following matrix of palindromes of 3 letters with r rows and c columns:

        static void Main(string[] args)
        {
            Console.Title = "Problem 7. Matrix of Palindromes";

            int r = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            string[,] matrix = new string[r, c];
            char[] cell = new char[3];
            int start = 97;

            for (int i = 0; i < r; i++)
            {
                cell[0] = (char)start;
                cell[1] = (char)start;
                cell[2] = (char)start;

                for (int j = 0; j < c; j++)
                {
                    cell[1] = (char)(start + j);
                    matrix[i, j] = string.Join("", cell);
                }
                start++;
            }

            PrintMatrix(matrix);
        }


        static void PrintMatrix(string[,] matrix)
        {
            int rowLength = matrix.GetLength(0);
            int colLength = matrix.GetLength(1);

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    Console.Write(string.Format("{0,3} ", matrix[i, j]));
                }
                Console.WriteLine();
            }
        }
    }
}
