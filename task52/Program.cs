// Задача №52

Console.Clear();


void Matrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(11);
            Console.Write(matrix[i, j] + " \t");
        }
        Console.WriteLine();
    }
}

void Sred(int[,] matrix)
{
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            sum += matrix[j, i];
        }
        Console.Write(Math.Round(sum / matrix.GetLength(0), 1) + "; ");
    }
}





int[,] matrix = new int[3, 4];

Matrix(matrix);
Console.WriteLine();
Console.WriteLine("Среднее аарифметическое каждого столбца ");
Sred(matrix);