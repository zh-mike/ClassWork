// Задача 35: Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123

void InputArrey (int[] arrey, int min, int max)
{
    for (int i = 0; i < arrey.Length; i++)   
        arrey[i] = new Random().Next(min, max);
        Console.WriteLine("[" + string.Join(", ", arrey) + "]");
}

// Функция подсчета
int Search (int []arrey, int n1, int n2)
{
    int count = 0;        
    for (int i = 0; i < arrey.Length; i++)
    {
        if (n1 <= arrey[i] && arrey[i] <=n2 ) 
            count ++;
    }
    return count;
}

int[] myArrey = new int[123];
InputArrey(myArrey, 0, 100);
Console.Write("От какого числа искать: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("До какого числа искать: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write(Search(myArrey, n1, n2));

