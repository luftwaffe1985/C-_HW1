void CheckWeekend ()
{
Console.Write("Введите номер дня недели и нажмите клавишу Enter: ");

int a = Convert.ToInt32(Console.ReadLine());

if (a > 5 & a < 8)
{
    Console.WriteLine("Выходной");
}
else if (a >= 1 & a <= 5 )
{
    Console.WriteLine("Рабочий");
}
else
{
    Console.WriteLine("В неделе 7 дней!");
}
}

CheckWeekend ();
CheckWeekend ();