// Найти значение двух чисел по сумме и произведению
Console.WriteLine("Назовите сумму чисел: ");
int s = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Назовите произведениее чисел: ");
int p = Convert.ToInt32(Console.ReadLine());

int D = s * s - 4 * p;
double x1 = (s + Math.Sqrt(D)) / 2;
double x2 = (s - Math.Sqrt(D)) / 2;
double y1 = s - x1;
double y2 = s - x2;
if (x1 + y1 == s && x1 * y1 == p)
    Console.WriteLine(x1 + " " + y1);
else
    Console.WriteLine(x2 + " " + y2);