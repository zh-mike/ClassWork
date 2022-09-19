// Перевернуть массив

int[] InputArrey( int[] arrey )
{
    for (int i = 0; i < arrey.Length; i++)
    {
        arrey[i] = new Random().Next(0, 10);
    } 
    return arrey;
}
void Reversal(int[] arrey)
{
    int sum = 0;
    for (int i = 0; i < arrey.Length/2; i++)
    {
        sum = arrey[i] + arrey[arrey.Length-i-1];
        arrey[i] = sum - arrey[i];
        arrey[arrey.Length-i-1] = sum - arrey[i];
    }
    Console.WriteLine("["+ string.Join(", ", arrey)+ "]");
}

Console.Clear();
int []Arrey = new int [5];
Arrey = InputArrey(Arrey);
Console.WriteLine("[" + string.Join(", ", Arrey) + "]");
Reversal(Arrey);
