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

int A = Prompt("Введите число А ");
int B = Prompt("Введите число B ");
int result = A;
for (int i =1; i<B;  i++ ){
    result = result*A;
}
System.Console.WriteLine(result);