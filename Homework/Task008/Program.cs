Console.Write("Введите число и нажмите клавишу Enter: ");

int a = Convert.ToInt32(Console.ReadLine());

int i = 2;

while (i <= a)
{
    if (i % 2 == 0)
    Console.WriteLine(i);
    i++;
}
