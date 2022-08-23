Console.Write("Введите первое число и нажмите клавишу Enter: ");

int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число и нажмите клавишу Enter: ");

int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число и нажмите клавишу Enter: ");

int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if (b > max) max = b;
if (c > max) max = c;

Console.WriteLine("max = " + max);
