//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа

int CentralNumber(int n)
{
int result = ((n % 100) / 10);
return result;
}

//
Console.Write("Input 3-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
int amount = number.ToString().Length;
if (amount < 3 || amount > 3)
{
Console.WriteLine("It's not a 3-digit number, repeat input");
}
else
{
	Console.WriteLine(CentralNumber(number));
}

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа


int ThirdNumber(int n)
{
int result = 0;
if (n >=100)
    {
        while (n > 999)
         {
             n = n / 10;
         }
    result = n % 10;
    }
    return result;
}

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
int amount = number.ToString().Length;
if (amount < 3)
{
Console.WriteLine("There's no 3rd figure");
}
else
{
	Console.WriteLine(ThirdNumber(number));
}

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.


bool IsDayOff(int n)
{
    bool result = false;
    if (n == 7 || n == 6)
        {
            result = true;
        }
    return result;
}
Console.WriteLine();

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(IsDayOff(number));



