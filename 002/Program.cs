// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10

int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int a = Prompt("Введите число  ");
int SumNumbers(int a)
{
    int sum = 0;
    while (a > 0)
    {

        sum = sum + a % 10;
        a = a / 10;

    }
    return sum;
}

int result = SumNumbers(a);
Console.WriteLine($"Сумма цифр в числе {result}");
