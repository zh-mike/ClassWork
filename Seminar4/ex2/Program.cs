// Найти количество символов в числе
int n = Convert.ToInt32(Console.ReadLine());
int coin = 0;
while (n>0)
{
    n = n /10;
    coin ++;
}
Console.WriteLine(coin);