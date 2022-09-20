// Задача 49: Задайте двумерный массив. 
// Найдите элементы, у которых оба индекса нечётные,
// и замените эти элементы на их квадраты.

void InputMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(10, 50);
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void AnswerMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i % 2 != 0 && j % 2 != 0)
                matrix[i, j] = Math.Pow(matrix[i, j], 2);

            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

double[,] matrix = new double[3, 4];
InputMatrix(matrix);
Console.WriteLine();
AnswerMatrix(matrix);
