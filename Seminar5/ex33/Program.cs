// Задача 33: Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.
void InputArrey (int[] arrey, int min, int max)
{
    for (int i = 0; i < arrey.Length; i++)   
        arrey[i] = new Random().Next(min, max);
        Console.WriteLine("[" + string.Join(", ", arrey) + "]");
}

// Функция поиска
string Search (int []arrey, int num)
{
    for (int i = 0; i < arrey.Length; i++)
        if (arrey[i] == num) return "yes";

    return "no";
}

int[] myArrey = new int[12];
InputArrey(myArrey, -9, 10);
Console.Write("Какую цифру нужно найти? ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write(Search(myArrey, n));
