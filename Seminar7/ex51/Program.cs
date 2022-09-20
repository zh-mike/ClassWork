// Задача 49: Задайте двумерный массив. 
// Найдите элементы, у которых оба индекса нечётные,
// и замените эти элементы на их квадраты.

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void AnswerMatrix(int[,] matrix)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j)
                sum +=matrix[i, j];
        }
    }
    Console.WriteLine(sum);
}

int[,] matrix = new int[3, 4];
InputMatrix(matrix);
Console.WriteLine();
AnswerMatrix(matrix);
