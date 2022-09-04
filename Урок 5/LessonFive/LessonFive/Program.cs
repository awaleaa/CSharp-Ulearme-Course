using System;

public class MainClass
{
    public static void Main()
    {
        int currentNumber = int.Parse(Console.ReadLine());
        int counterOfNumbers = 0;
        if ((currentNumber < 1) || (currentNumber > 27))
            Console.WriteLine("Incorrect input");
        else
        {
            for (int i = 100; i < 1000; i++)
            {
                if (SumOfNumbers(toIntegerArray(i)) == currentNumber)
                {
                    Console.Write(i + " ");
                    counterOfNumbers++;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Tne amount of numbers is {counterOfNumbers}");
        }
    }

    public static int[] toIntegerArray(int currentNumber)
    {
        int intermediateVariable = currentNumber;
        List<int> ourMassiveOfNumbers = new List<int>();
        while (intermediateVariable > 0)
        {
            ourMassiveOfNumbers.Add(intermediateVariable % 10);
            intermediateVariable = intermediateVariable / 10;
        }
        return ourMassiveOfNumbers.ToArray();
    }

    public static int SumOfNumbers(int[] ourMassiveOfNumbers)
    {
        int sum = ourMassiveOfNumbers[0] + ourMassiveOfNumbers[1] + ourMassiveOfNumbers[2];
        return sum;
    }
}
