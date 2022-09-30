// Задача 63. Вывезти числа то 1 до N.
string AllNumber(int n, int oneNum)
{
if (n == oneNum)
return $"{oneNum}";

return AllNumber(n - 1, oneNum) + $" {n}";
}

Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число: ");
int oneNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(AllNumber(number, oneNum));


