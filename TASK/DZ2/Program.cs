// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет


int ReadInt(string value, string error = "Ошибочно ввели данные ")
{
    try
    {
        System.Console.Write(value);
        return Convert.ToInt32(Console.ReadLine());
    }
    catch
    {
        System.Console.WriteLine(error);
        return 0;
    }
}

int[,] FillMatrix(int row, int col, int min = 0, int max = 10)
{
    Random rand = new Random();
    int[,] array = new int[row, col];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(min, max + 1);
        }
    }
    return array;
}
void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

void Main()
{
    int row = ReadInt("Введите количество строк: ");
    int col = ReadInt("Введите количество столбцов: ");
    int arrayX = ReadInt("Введите индекс по строке ");
    int arrayY = ReadInt("Введите индекс по столбцу ");
    int[,] arrayMatrix = FillMatrix(row, col, 0, 100);
    PrintMatrix(arrayMatrix);
    if (row <= arrayX && col <= arrayY)
    {
        System.Console.WriteLine($"{arrayX}, {arrayY} -> Такого числа нету");
    }
    else
    {
        System.Console.WriteLine($"{arrayX}, {arrayY} -> {arrayMatrix[arrayX, arrayY]}");
    }
}
Main();