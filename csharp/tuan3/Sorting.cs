using System;

public class Sorting
{
    // Sorting nhan vao mang IComparable[] - bat ky class nao implement IComparable deu dung duoc
    // Tuong duong Java: public static void selectionSort(Comparable[] list)
    public static void selectionSort(IComparable[] list)
    {
        int min;
        IComparable temp;

        for (int index = 0; index < list.Length - 1; index++)
        {
            min = index;
            for (int scan = index + 1; scan < list.Length; scan++)
            {
                if (list[scan].CompareTo(list[min]) < 0)
                {
                    min = scan;
                }
            }

            // Swap the values
            temp = list[min];
            list[min] = list[index];
            list[index] = temp;
        }
    }

    // Insertion Sort - cung nhan IComparable[]
    public static void insertionSort(IComparable[] list)
    {
        for (int index = 1; index < list.Length; index++)
        {
            IComparable key = list[index];
            int position = index;

            // Shift larger values to the right
            while (position > 0 && key.CompareTo(list[position - 1]) < 0)
            {
                list[position] = list[position - 1];
                position--;
            }

            list[position] = key;
        }
    }
}