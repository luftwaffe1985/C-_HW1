// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

string CheckPalindrome ()
{
Console.Write("Введе число: ");
int number = Convert.ToInt32(Console.ReadLine());
int number1 = number;
int result = 0;
        
    while (number1 > 0) 
    {
    result *= 10;
    result += number1 % 10;
    number1 /= 10;
    }
    if (number == result)
    {
        return $"Число {number} является палиндромом";
    }
    else
    {
        return $"Число {number} не является палиндромом";
    }
}
try
{
    Console.WriteLine(CheckPalindrome ());
}
catch
{
    Console.WriteLine("необходимо ввести целочисленное значение цифрами");
}

