using System;

class Programm
{
    static void Main()
    {
        int[] array = new int[5] { -4, 3, 1, 5, 5 };
        int max = -105; int count = 0;
        for (int i = 0; i < 5; i++)
        {
            if (max < array[i])
            {
                max = array[i];
            }
            Console.Write($"{array[i]} ");
        }
        for (int i = 0; i < 5; i++)
        {
            if (max == array[i])
            {
                count++;
            }
        }
        Console.WriteLine($"\n{count}");
    }
}
