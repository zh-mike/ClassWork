// // Сумма арефметической прогрессии. Формула ((A1 + An) / 2) * An 
// double n = Convert.ToInt32(Console.ReadLine());  // При использовании этой формулы не забыть поставить double


//Вариант 1

//                     //int sum = 0;
//                     // for (int i = 1; i <=n; i++)
//                     // {
//                     //     sum += i; //sum = sum + i; 
//                     // }
//                     //Console.Write(sum);


//Вариант2

// Console.Write((1+n)/2*n);





// // Найти количество символов в числе
// int n = Convert.ToInt32(Console.ReadLine());
// int coin = 0;
// while (n>0)
// {
//     n = n /10;
//     coin ++;
// }
// Console.WriteLine(coin);




// // Пайти произведение чисел от 1 до n:
// int n = Convert.ToInt32(Console.ReadLine());  // При использовании этой формулы не забыть поставить double
// int sum = 1;
// for (int i = 2; i <=n; i++)
// {
//     sum *= i; 
// }
// Console.Write(sum);



// //Завести массив и наполнить его 0 1 в случайном порядке
int [] a = new int[8];

for (int i = 0; i < a.Length; i++)
{
    a[i] = new Random().Next(0,2);
    //Console.Write($"{a[i]}, ");  //Можно так но лучше как указано ниже
}
Console.WriteLine("[" + string.Join(",", a) + "]"); // так красиво можно выводить массив




