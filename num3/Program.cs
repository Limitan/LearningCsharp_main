using System;

class Programm
{
    static void Main()
    {
        int length = 10; int min1 = 101; int min2 = 101; int min3 = 101;
        int[] array = Creating(length);
        Print(array);
        Mins1(array);
        Mins2(array);
        Mins3(array);
    }

    static int[] Creating(int length)
    {
        Random rand = new Random();
        int[] array = new int[length];
        for (int i = 0; i < length; i++)
        {
            int a = rand.Next(-100, 100);
        }
        return array;
    }

    static void Print(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine($"{array[i]}, ");
        }
        Console.WriteLine();
    }

    static int Mins1(int[] array, int min1)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min1)
            {
                min1 = array[i];
            }
        }
        return min1;
    }

    static int Mins2(int[] array, int min2, int min1)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min2 && array[i] > min1)
            {
                min2 = array[i];
            }
        }
        return min2;
    }

    static int Mins3(int[] array, int min3, int min2)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min3 && array[i] > min2)
            {
                min3 = array[i];
            }
        }
        return min3;
    }
}
