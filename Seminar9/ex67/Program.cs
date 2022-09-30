// Задача 67. Вывести сумму цифр числа через рекурсию.
int AllNumber(int n, int s)
{
    if (s == 0)
        return 1;
    return AllNumber(n, s - 1) * n;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: ");
int s = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(AllNumber(number, s));
