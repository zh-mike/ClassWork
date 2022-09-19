// Копирование массива
int[] a = {1, 2, 3, 4, 5};
int[] b = new int [a.Length];
Console.WriteLine("[" + String.Join(", ", a) + "]");
Console.WriteLine("[" + String.Join(", ", b) + "]");
Console.WriteLine();

for (int i = 0; i < a.Length; i++)
{
    b[i]=a[i];
}

Console.WriteLine("[" + String.Join(", ", a) + "]");
Console.WriteLine("[" + String.Join(", ", b) + "]");
