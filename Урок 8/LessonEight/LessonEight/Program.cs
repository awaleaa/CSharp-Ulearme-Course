using System;
using System.Collections.Generic;

public class MainClass
{
    public static void Main()
    {
        int[] arrayOfOurNumbers = new int[] { 3, 5, 7, 11, 4, 5 };
        int[] arrayOfOurNumbers2 = new int[arrayOfOurNumbers.Length];
        int counterOfShifts = 0;
        int counterOfShifts2 = 0;
        int counterOfShifting = int.Parse(Console.ReadLine());
        if (counterOfShifting > arrayOfOurNumbers.Length)
        {
            Console.WriteLine("Incorrect input");
        }
        for (int i = 0; i < arrayOfOurNumbers.Length - 1; i++)
        {
            if ((counterOfShifts + counterOfShifts2) <= arrayOfOurNumbers.Length)
            {
                if (i < (arrayOfOurNumbers.Length - counterOfShifting))
                {
                    arrayOfOurNumbers2[i] = arrayOfOurNumbers[i + counterOfShifting];
                    counterOfShifts++;
                }
                else
                {
                    for (int j = 0; j < arrayOfOurNumbers.Length - counterOfShifts; j++)
                    {
                        arrayOfOurNumbers2[i] = arrayOfOurNumbers[j];
                        counterOfShifts2++;
                        i++;
                    }
                }
            }
            else break;
        }
        for (int i = 0; i < arrayOfOurNumbers.Length; i++)
            Console.Write(arrayOfOurNumbers2[i] + " ");
    }
}