using System;
using System.Collections.Generic;
using System.Linq;

public class MainClass
{
    public static void Main()
    {
		WriteBoard(8);
		WriteBoard(1);
		WriteBoard(2);
		WriteBoard(3);
		WriteBoard(10);
	}
    private static void WriteBoard(int size)
    {
        for (int i = 0; i < size; i++)
        {
            if (i % 2 == 0)
            {
                for (int j =0; j < size; j++)
                {
                    if ((j % 2) == 0)
                        Console.Write('#');
                    else
                        Console.Write('.');
                }
                Console.WriteLine();
            }
            else
            {
                for (int j = 0; j < size; j++)
                {
                    if ((j % 2) == 0)
                        Console.Write('.');
                    else
                        Console.Write('#');
                }
                Console.WriteLine();
            }
        }

    }
}