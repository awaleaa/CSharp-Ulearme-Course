using System;

public class MainClass
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        CheckIsOurNumberIsLucky(toIntegerArray(number));
    }
    public static void CheckIsOurNumberIsLucky (int[] listOfDigit)
    {
        int sumOfFirstThreeDigit = listOfDigit[5] + listOfDigit[4] + listOfDigit[3];
        int sumOfLastThreeDigit = listOfDigit[2] + listOfDigit[1] + listOfDigit[0];
        if (sumOfFirstThreeDigit == sumOfLastThreeDigit)
        {
            Console.WriteLine("The ticket number is lucky");
        }
        else if ((sumOfFirstThreeDigit - sumOfLastThreeDigit) == 1)
        {
            Console.WriteLine("Im exactly lucky one");
        }
        else
            Console.WriteLine("In next time");
    }

    public static int[] toIntegerArray(int number)
    {
        int a = number;
        List<int> listOfDigit = new List<int>();
        while (a > 0)
        {
            listOfDigit.Add(a % 10);
            a = a / 10;
        }
        return listOfDigit.ToArray();
    }
}