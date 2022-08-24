//эту написала до того, как досмотрела семинар и услышала вашу просьбу не делать через Math. Pow

// Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.

int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int A = Prompt("Введите число А ");
int B = Prompt("Введите число B ");


System.Console.WriteLine(Math. Pow(A,B));