// Задача №50

Console.Clear();


int[,] matr = new int[3, 4];

Console.Write("Введите номер строки: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int y = Convert.ToInt32(Console.ReadLine());


void SozdMassiv(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11);
            Console.Write(matrix[i, j] + " \t");
        }
        Console.WriteLine();
    }
}

void Tochka(int[,] matrix)
{
    if (x > matrix.GetLength(0) || y > matrix.GetLength(1))
            {
                Console.Write(" по таким параметрам нельзя найти точку!");
                
            }
    else 
    {
        for (int i = 1; i < matrix.GetLength(0); i++)
    {
        for (int j = 1; j < matrix.GetLength(1); j++)
        {
            if ( i == x && j == y)
            {
                Console.WriteLine($" Строка {x}");
                Console.WriteLine($" Столбец {y}");
                Console.WriteLine($" Вывод {matrix[x-1, y-1]}");
            }
            
            
        
        }
    
    }
    }
}




SozdMassiv(matr);
Tochka(matr);