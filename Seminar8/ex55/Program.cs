// // Меняем первую строку двумерного массива с последней

// Моё рещение
// Console.Clear();


// void InputMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             matrix[i, j] = new Random().Next(-10, 11);
//     }
// }


// void PrintMatrix(int[,] matrix)
// {
//     Console.WriteLine();
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             Console.Write(matrix[i, j] + " \t");
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// void ReleaseMatrix(int[,] matrix, int[,] newMatrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             newMatrix[j,i] = matrix[i,j];
            
//         }
//     }
// }


// Console.Write("Введите кол-во строк: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите кол-во столбцов: ");
// int m = Convert.ToInt32(Console.ReadLine());
// if (n != m) Console.Write("Процедура не возможна");
// else
// {
//     int[,] matrix = new int[n, m];
//     int[,] newMatrix = new int[n,m];

//     InputMatrix(matrix);
//     Console.WriteLine("Исходный двумерный массив: ");
//     PrintMatrix(matrix);
//     ReleaseMatrix(matrix, newMatrix);
//     Console.WriteLine("Конечный двумерный массив: ");
//     PrintMatrix(newMatrix);
// }

// Как надо было
Console.Clear();


void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(-10, 11);
    }
}


void PrintMatrix(int[,] matrix)
{
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write(matrix[i, j] + " \t");
            Console.WriteLine();
    }
    Console.WriteLine();
}
void ReleaseMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = i+1; j < matrix.GetLength(1); j++)
        {
            int x = matrix[i,j];
            matrix[i,j] = matrix[j,i];
            matrix[j,i] = x;
            
        }
    }
}


Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
if (n != m) Console.Write("Процедура не возможна");
else
{
    int[,] matrix = new int[n, m];
    InputMatrix(matrix);
    Console.WriteLine("Исходный двумерный массив: ");
    PrintMatrix(matrix);
    ReleaseMatrix(matrix);
    Console.WriteLine("Конечный двумерный массив: ");
    PrintMatrix(matrix);
}