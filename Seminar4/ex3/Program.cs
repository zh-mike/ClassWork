// Найти произведение чисел от 1 до n:
int n = Convert.ToInt32(Console.ReadLine());  // При использовании этой формулы не забыть поставить double
int sum = 1;
for (int i = 2; i <=n; i++)
{
    sum *= i; 
}
Console.Write(sum);
