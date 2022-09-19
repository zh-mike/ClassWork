// Перевод из 10ой системы исчисления в 2ичную
Console.Write("Какое число нужно перевести? ");
int a = Convert.ToInt32(Console.ReadLine());
string answer = string.Empty;

while (a!=0)
{
    answer = Convert.ToString(a%2)+ answer;
    a = a/2;
}
Console.Write(answer);
