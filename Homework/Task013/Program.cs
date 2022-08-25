Console.Write("Введите и нажмите клавишу Enter: ");

string arr = Console.ReadLine();
int len = arr.Length;
int n = Convert.ToInt32(arr);
int i = 0;

if (len <= 2)
{
    Console.WriteLine("Третьей цифры нет!");
}
else
{
    while (i < (len - 3))

    {
        n = n / 10;
        i++;
    }
    Console.WriteLine(n % 10);
}
