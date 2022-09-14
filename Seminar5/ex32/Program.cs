// Задача 32: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
void InputArrey (int[] arrey, int min, int max)
{
    for (int i = 0; i < arrey.Length; i++)   
        arrey[i] = new Random().Next(min, max);
    Console.WriteLine("[" + string.Join(", ", arrey) + "]");
}

// Процедура замены знака
void Change (int []arrey)
{
    for (int i = 0; i < arrey.Length; i++)
        arrey[i] *= -1; 

    Console.WriteLine("[" + string.Join(", ", arrey) + "]");
}

int[] myArrey = new int[12];
InputArrey(myArrey, -9, 10);
Change(myArrey);
