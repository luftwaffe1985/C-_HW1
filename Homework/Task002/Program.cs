Console.Write("Введите первое число и нажмите клавишу Enter: ");

int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число и нажмите клавишу Enter: ");

int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.WriteLine("Максимальное число " + a);
}
else
{
    Console.WriteLine("Максимальное число " + b);
}