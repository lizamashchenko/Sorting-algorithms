using System;

class Program
{
    static void Main()
    {
        int[] a = new int[] {1, 2, 5, 4, 2, 0};
        int[] result = QuickSort(a, 0, a.Length-1);
        foreach(int x in result)
            Console.Write(x + ' ');
    }
    
    
  
    static void Swap(ref int x, ref int y)
    {
        int rez = x;
        x = y;
        y = rez;
    }
    static int Partition(int[] a, int minIndex, int maxIndex)
    {
        int pivot = minIndex - 1;
        for (int i = minIndex; i < maxIndex; i++)
        {
            if (a[i] < a[maxIndex])
            {
                pivot++;
                Swap(ref a[pivot], ref a[i]);
            }
        }

        pivot++;
        Swap(ref a[pivot], ref a[maxIndex]);
        return pivot;
    }
    static int[] QuickSort(int[] a, int minIndex, int maxIndex)
    {
        if (minIndex >= maxIndex)
        {
            return a;
        }
        int pivotIndex = Partition(a, minIndex, maxIndex);
        QuickSort(a, minIndex, pivotIndex - 1);
        QuickSort(a, pivotIndex + 1, maxIndex);
        return a;
    }
}
