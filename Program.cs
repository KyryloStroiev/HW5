using System;
class Test
{
    public static void Main()
    {
        int[] ArrayHW = { 53, 21, 10, 47, 65 };
        SortSelection(ArrayHW);
        Console.WriteLine("Сортування масиву Selection");
        printArraySelection(ArrayHW);
        int[] ArrayHW2 = { 434, 534, 32, 65 };
        SortBubble(ArrayHW2);
        Console.WriteLine("Сортування масиву Bubble");
        printArrayBuble(ArrayHW2);
        int[] ArrayHW3 = { 343, 21, 43, 22 };
        SortInsertion(ArrayHW3);
        Console.WriteLine("Сортування масиву Insertion");
        printArrayInsertion(ArrayHW3);
    }


    static void SortSelection(int[] ArrayHW)
    {
        int n = ArrayHW.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int minIdx = i;
            for (int j = i + 1; j < n; j++)
                if (ArrayHW[j] < ArrayHW[minIdx])
                    minIdx = j;
            int temp = ArrayHW[minIdx];
            ArrayHW[minIdx] = ArrayHW[i];
            ArrayHW[i] = temp;
        }
    }

    static void SortBubble(int[] ArrayHW2)
    {
        int n = ArrayHW2.Length;
        for (int i = 0; i < n - 1; i++)
            for (int j = 0; j < n - i - 1; j++)
                if (ArrayHW2[j] > ArrayHW2[j + 1])
                {

                    int temp = ArrayHW2[j];
                    ArrayHW2[j] = ArrayHW2[j + 1];
                    ArrayHW2[j + 1] = temp;
                }
    }

    static void SortInsertion(int[] ArrayHW3)
    {
        int n = ArrayHW3.Length;
        for (int i = 1; i < n; ++i)
        {
            int key = ArrayHW3[i];
            int j = i - 1;


            while (j >= 0 && ArrayHW3[j] > key)
            {
                ArrayHW3[j + 1] = ArrayHW3[j];
                j = j - 1;
            }
            ArrayHW3[j + 1] = key;
        }
    }

    static void printArraySelection(int[] ArrayHW)
    {
        int n = ArrayHW.Length;
        for (int i = 0; i < n; ++i)
            Console.Write(ArrayHW[i] + " ");
        Console.WriteLine();
    }

    static void printArrayBuble(int[] ArrayHW2)
    {
        int n = ArrayHW2.Length;
        for (int i = 0; i < n; ++i)
            Console.Write(ArrayHW2[i] + " ");
        Console.WriteLine();
    }

    static void printArrayInsertion(int[] ArrayHW3)
    {
        int n = ArrayHW3.Length;
        for (int i = 0; i < n; ++i)
            Console.Write(ArrayHW3[i] + " ");

        Console.Write("\n");
    }
}