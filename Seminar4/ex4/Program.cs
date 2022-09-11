// //Завести массив и наполнить его 0 1 в случайном порядке
int [] a = new int[8];

for (int i = 0; i < a.Length; i++)
{
    a[i] = new Random().Next(0,2);
    //Console.Write($"{a[i]}, ");  //Можно так но лучше как указано ниже
}
Console.WriteLine("[" + string.Join(",", a) + "]"); // так красиво можно выводить массив