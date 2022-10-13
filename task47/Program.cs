// Задача №47
Console.Clear();

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] matr = new double[m, n];

void MaiMartix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().NextDouble() *  10;
            Console.Write(Math.Round(matrix[i , j], 1) + " \t");
        }
    Console.WriteLine();
    }
}
MaiMartix(matr);