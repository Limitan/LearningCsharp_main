using System;

class Programm
{
    static void Main()
    {
        Random rand = new Random();
        int[] array = new int[20];
        int min = 105; int max = -105;
        for (int i = 0; i < 20; i++)
        {
            int a = rand.Next(-100, 101);
            array[i] = a;
            if (a % 2 == 0 && a > 0)
            {
                if (min > a)
                {
                    min = a;
                }
                if (max < a)
                {
                    max = a;
                }
            }
            Console.Write($"{a} ");
        }
        if (min == 105)
        {
            Console.WriteLine("Четных положительных чисел нет.");
        }
        Console.WriteLine($"\nMin: {min} Max: {max}");

    }
}