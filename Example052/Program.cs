/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

        int GetNumber(string message)
        {
            int result = 0;

            while (true)
            {
                Console.WriteLine(message);

                if (int.TryParse(Console.ReadLine(), out result) && result >= 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Такого элемента нет");
                }
            }

            return result;
        }

        int[,] InitMatrix(int rows, int columns)
        {
            int[,] matrix = new int[rows, columns];
            Random rnd = new Random();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = rnd.Next(0, 100);
                }
            }

            return matrix;
        }

        void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }

                Console.WriteLine();
            }
        }

        double[] GetAverageColumn(int[,] matrix)
        {
            double[] averageValues = new double[matrix.GetLength(1)];
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                double result = 0;
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    result += matrix[i, j];
                }
                averageValues[j] = Math.Round((result / matrix.GetLength(0)),1);
            }
            return averageValues;
        }

        int rows = GetNumber("Введите количество строк: ");
        int columns = GetNumber("Введите количество столбцов: ");
        int[,] matrix = InitMatrix(rows, columns);
        PrintMatrix(matrix);
        
        double[] averageValues = GetAverageColumn(matrix);
        Console.Write($"Среднее арифметическое элементов в каждом столбце =");
        Console.WriteLine("{0}",string.Join("; ", averageValues));