// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, 
// второй и предпоследний и т.д. Результат запишите в новом массиве.
// Перемножить первое число массива с последним второе с вторым с конца и тд
void InputArrey (int[] arrey, int min, int max)
{
    for (int i = 0; i < arrey.Length; i++)   
        arrey[i] = new Random().Next(min, max);
        Console.WriteLine("[" + string.Join(", ", arrey) + "]");
}

// Функция поиска
void Search (int [] arrey, int [] printArrey)
{   
    int j = 0;
    for (int i = 0; i < arrey.Length / 2; i++)
    {   
        printArrey[j] = arrey[i] * arrey[(arrey.Length-1) -i];
        j++;
    }
    if (arrey.Length % 2 != 0)
        printArrey[j] = arrey[arrey.Length /2];
}
Console.Clear();
Console.Write("Сколько элементов в массиве? ");
int[] myArrey = new int[Convert.ToInt32(Console.ReadLine())];
InputArrey(myArrey, 0, 10); // Цифры это диапазон рандомных чисел в массиве
int []answerArrey = new int[myArrey.Length / 2];
if (myArrey.Length % 2 != 0)
    answerArrey = new int[myArrey.Length / 2+1];
Search(myArrey, answerArrey);
Console.WriteLine("[" + string.Join(", ", answerArrey) + "]");


