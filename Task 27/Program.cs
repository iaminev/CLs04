/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

int ReadPositiveNumber(string message) //consider we are working only with positive numbers
{
    Console.Write(message);
    string numberAsString = System.Console.ReadLine()!;
    int numberAsNumber;
    bool itIsANumber = int.TryParse(numberAsString, out numberAsNumber);
    if (itIsANumber && numberAsNumber > 0) return numberAsNumber;
    else return -1;
}

int CaclulateSumOfDigits(int number)
{
    int sumOfDigits = 0;
    string myString = number.ToString();
    for (int i = 0; i < myString.Length; i++)
    {
        //usual way
        //sumOfDigits += Convert.ToInt32(new string(myString[i], 1));

        //alternative way
        sumOfDigits += (myString[i] - '0');
    }
    return sumOfDigits;
}

int number = ReadPositiveNumber("Enter a positive number: ");
if (number != -1)
{
    Console.WriteLine($"{number} -> {CaclulateSumOfDigits(number)}");
}
else
    Console.WriteLine($"There is an input problem, entered value seems not to be a proper number");
