// Задача определить может ли быть треугольник с такими сторонами
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

if (a+b<c || a+c<b || c+b<a)
{
    Console.WriteLine("No");
}
else Console.WriteLine("Yes");

