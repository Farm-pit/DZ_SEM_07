// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


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
   
    double[] AverageCol(int[,] matrix)
    {
        double[] answer = new double[matrix.GetLength(1)];
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                answer[j] += matrix[i, j];
            }
            answer[j] /= matrix.GetLength(0);
        }
        return answer;
    }

    void PrintArray(double[] array)
    {
        System.Console.WriteLine($"Среднее арифметическое значение каждого столбца матрицы: [ {string.Join(", ", array)} ]");
    }

    void Main()
    {
        int row = ReadInt("Введите количество строк: ");
        int col = ReadInt("Введите количество столбцов: ");

        int[,] matrix = FillMatrix(row, col);

        System.Console.WriteLine("Исходная матрица:");
        PrintMatrix(matrix);

        double[] averages = AverageCol(matrix);
        PrintArray(averages);
    }

Main();