// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
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

double[,] FillMatrix(int row, int col, int min = 0, int max = 10)
{
    Random rand = new Random();
    double[,] array = new double[row, col];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(min + rand.NextDouble() * (max - min), 3);
        }
    }
    return array;
}
void PrintMatrix(double[,] array)
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
double[,] arrayMatrix = FillMatrix(row, col, 0, 100);
PrintMatrix(arrayMatrix);
}
Main();



