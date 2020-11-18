using System;

class Program
{
    static void Main()
    {
        int[] a = new int[] { 12, 11, 13, 5, 6, 7 };
        HeapSort(a);
        for(int i = 0; i < a.Length; i++)
           Console.Write(a[i] + ' ');
    }
    static void HeapSort(int[] a)
    {
        int n = a.Length;
        for (int i = n / 2 - 1; i >= 0; i--)
            Heapify(a, n, i);
        for (int i = n - 1; i > 0; i--) 
        {
            int rez = a[0];
            a[0] = a[i];
            a[i] = rez;
            Heapify(a, i, 0);
        }
    }
    static void Heapify(int[] a, int n, int curr)
    {
        int largest = curr;
        int left = 2 * curr + 1;
        int right = 2 * curr + 2;
        if (left < n && a[left] > a[largest])
            largest = left;
        if (right < n && a[right] > a[largest])
            largest = right;
        if (largest != index)
        {
            int rez = a[index];
            a[index] = a[largest];
            a[largest] = rez;
            Heapify(a, n, largest);
        }
    }
}
