using System;

namespace Pr19.SpiralMatrix
{
    class SpiralMatrix
    {

        //        Problem 19. ** Spiral Matrix
        //Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix holding the numbers from 1 to n*n in the form of square spiral like in the examples below. 

        static void Main(string[] args)
        {
            Console.Title = "Problem 19. ** Spiral Matrix";

            int n;

            do
            {
                int.TryParse(Console.ReadLine(), out n);
            } while (n < 1 || n > 20);


            int[,] matrix = new int[n, n];

            FillMatrix(matrix, n);

            PrintMatrix(matrix, n);
        }

        private static void FillMatrix(int[,] matrix, int n)
        {
            int positionX = 0;
            int positionY = 0;

            int direction = 0; // The initial direction is "right"
            int stepsCount = n-1; // Perform 1 step in current direction
            int stepPosition = 0; // 0 steps already performed
            int stepChange = 0;// every 3 direction changes will reduce stepsCount by 1

            for (int i = 1; i <= n * n; i++)
            {
                // Fill the current cell with the current value
                matrix[positionY, positionX] = i;

                // Check for direction / step changes
                if (stepPosition < stepsCount)
                {
                    stepPosition++;
                }
                else
                {
                    stepChange++;
                    stepPosition = 1;

                    if (stepChange % 3 == 0)
                    {
                        stepsCount--;
                        stepChange = 1;
                    }

                    direction = (direction + 1) % 4;
                }

                /// Move to the next cell in the current direction
                switch (direction)
                {
                    case 0:
                        positionX++;
                        break;
                    case 1:
                        positionY++;
                        break;
                    case 2:
                        positionX--;
                        break;
                    case 3:
                        positionY--;
                        break;
                }
            }
        }

        private static void PrintMatrix(int[,] matrix, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,3}", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }


    }
}
