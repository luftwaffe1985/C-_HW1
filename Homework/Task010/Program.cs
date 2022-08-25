void PrintSecondNumber ()
{
Console.Write("Введите трехзначное и нажмите клавишу Enter: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = a / 10;
b = b % 10;

Console.WriteLine(b);
}

PrintSecondNumber (); 

