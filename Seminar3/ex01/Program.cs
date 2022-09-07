// See https://aka.ms/new-console-template for more information
Console.Write("Координат X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Координат Y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0) Console.Write(1);
if (x < 0 && y > 0) Console.Write(2);
if (x < 0 && y < 0) Console.Write(3);
if (x > 0 && y < 0) Console.Write(4);