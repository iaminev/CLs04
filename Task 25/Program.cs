/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

int ReadPositiveNumber(string message)
{
    Console.Write(message);
    string numberAsString = System.Console.ReadLine()!;
    int numberAsNumber;
    bool itIsANumber = int.TryParse(numberAsString, out numberAsNumber);
    if (itIsANumber) return numberAsNumber;
    else return -1;
}

long MyAToPowerB(int A, int B)
{
    if (B == 0) return 1;
    int multiplier = A;
    for (int i = 1; i < B; i++) A *= multiplier;
    return A;
}

int A = ReadPositiveNumber("Enter A: ");
int B = ReadPositiveNumber("Enter B: ");
if (A != -1 && B != -1)
{
    Console.WriteLine($"A^B={MyAToPowerB(A, B)}");
}
else
    Console.WriteLine($"There is an input problem");
