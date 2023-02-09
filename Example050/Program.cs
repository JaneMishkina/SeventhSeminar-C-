/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
пользователь вводит индексы 10, 10 - такого элемента нет.
пользователь вводит индексы 0, 2 - выводим элеменет 7*/


int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result) && result >= 0)
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
            matrix[i,j] = rnd.Next(0, 100);
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
            Console.Write($"{matrix[i,j]} ");
        }

        Console.WriteLine();
    }
}

int FindNumber(int [,] matrix)
{
int result = 0;
int findRow = GetNumber("Введите индекс строки:");
int findColumn = GetNumber("Введите индекс столбца:");

         if(findRow <= matrix.GetLength(0) && findColumn <= matrix.GetLength(1))
        {
            result = matrix[findRow, findColumn];
            Console.WriteLine($"{result}");
        }
        else
        {
            Console.WriteLine("Ввели не корректное число, выходящее за границы матрицы.");
        }

    return result;
}


int countOfRows = GetNumber("Введите кол-во строк:");
int countOfColumns = GetNumber("Введите кол-во столбцов:");
int[,] matrix = InitMatrix(countOfRows, countOfColumns);


PrintMatrix(matrix);
FindNumber(matrix);
