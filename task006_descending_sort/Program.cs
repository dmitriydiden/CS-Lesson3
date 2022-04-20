﻿// Задача. Сортировка массива по убыванию

Console.Clear();
int[] array = {1, 5, 4, 3, 2, 6, 7};

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i<count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
        for (int i=0; i<array.Length - 1 ; i++)
        {
            int maxPosition = i;

            for (int j=i+1; j< array.Length; j++)
            {
                if(array[j]> array[maxPosition]) maxPosition = j;
            }

            int temporary = array[i];
            array[i] = array[maxPosition];
            array[maxPosition] = temporary;            
        }
}
PrintArray(array);
SelectionSort(array);
PrintArray(array);



