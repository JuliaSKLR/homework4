// 1: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)

int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}


int Pow(int a, int b)
{
    int pow = 1;
    for (int i = 0; i <b; i++ )
    {
    pow = pow * a;
}
return pow;
}
int a = Prompt("Введите число А ");
int b = Prompt("Введите число B ");
int result = Pow(a,b);
System.Console.WriteLine($"A в степени В = {result}");