// Последоватьльность фибоначи

// Мое решение
// void Fibonachi(int[] arrey)
// {
//     for (int i = 2; i < arrey.Length; i++)
//     {
//         arrey[1] = 1;
//         arrey[i] = arrey[i-2]+arrey[i-1];
//     }
//     Console.WriteLine(string.Join(" ",arrey));
// }
// Console.Write("Введите число ");
// int a = Convert.ToInt32(Console.ReadLine());
// int[] arrey = new int [a];
// Fibonachi(arrey);

//Решение препода
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int a0 = 0, a1 = 1;
for (int i = 0; i < n; i++)
{
    Console.Write(a0 + " ");
    int x = a0 + a1;
    a0 = a1;
    a1 = x;
}

