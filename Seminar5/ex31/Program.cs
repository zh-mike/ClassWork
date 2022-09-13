// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
// сумма отрицательных равна -20.

// Заполнение массива рандомными числами от мин  до макс
void InputArrey (int[] arrey, int min, int max)
{
    for (int i = 0; i < arrey.Length; i++)   
        arrey[i] = new Random().Next(min, max);
}

// Находим сумму положительных чисел
void PositiveNum(int[] arrey)
{
    int sumP = 0;
    for (int i = 0; i < arrey.Length; i++)
    {
        if(arrey[i] > 0)
        sumP += arrey[i];
    }
    Console.WriteLine(sumP);
}

// Находим сумму отрицательных чисел
void NegativeNum(int[] arrey)
{
    int sumN = 0;
    for (int i = 0; i < arrey.Length; i++)
    {
        if(arrey[i] < 0)
        sumN += arrey[i];
    }
    Console.WriteLine(sumN);
}

int[] myAreey = new int[12];
InputArrey(myAreey, -9, 10);
Console.WriteLine("[" + string.Join(", ", myAreey) + "]");
PositiveNum(myAreey);
NegativeNum(myAreey);