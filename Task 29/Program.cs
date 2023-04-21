/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33-> [6, 1, 33]*/

int[] InputArray()
{
    string digits = "0123456789";
    System.Console.Write("Input a bunch of numbers: ");
    string arrayAsString = System.Console.ReadLine()!;

    List<int> numbers = new List<int>();

    string currentNumber = "";
    int numberAsNumber;
    for (int i = 0; i < arrayAsString.Length; i++)
    {
        int indexOfChar = digits.IndexOf(arrayAsString[i]);
        //System.Console.WriteLine("" + arrayAsString[i] + " - " + indexOfChar);

        if (indexOfChar >= 0)
        {
            currentNumber += arrayAsString[i];
        }
        else
        {
            if (currentNumber.Length > 0)
            {
                bool itIsANumber = int.TryParse(currentNumber, out numberAsNumber);
                numbers.Add(numberAsNumber);
                currentNumber = "";
            }
        }
    }
    if (currentNumber.Length > 0) // pick up the last number
    {
        bool itIsANumber = int.TryParse(currentNumber, out numberAsNumber);
        numbers.Add(numberAsNumber);
    }
    return numbers.ToArray();
}

int[] myArray = InputArray();
System.Console.Write("[");
for (int i = 0; i < myArray.Length; i++)
{
    System.Console.Write(myArray[i]);
    System.Console.Write((i == myArray.Length - 1) ? "" : ", ");
}
System.Console.Write("]");
