// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double getDistance3D ()
{
Console.Write("введите координату х1 ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите координату y1 ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите координату z1 ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите координату x2 ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите координату y2 ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите координату z2 ");
int z2 = Convert.ToInt32(Console.ReadLine());           

double S = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)), 2);

return S;
}
try
{
Console.WriteLine(getDistance3D ());
}
catch
{
Console.WriteLine("Надо было вводить именно целые числа");  
}
