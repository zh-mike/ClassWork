// Задачка про нахождение растояния между точками

Console.Write("Ведите координаты точки A по X : ");
int ax = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите координаты точки A по Y : ");
int ay = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите координаты точки B по X : ");
int bx = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите координаты точки B по Y : ");
int by = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Math.Sqrt(Math.Pow(ax - bx, 2)+ Math.Pow(ay - by,2)));