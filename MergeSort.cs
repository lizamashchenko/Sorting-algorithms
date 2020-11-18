using System;

class Program
{
    static void Main()
    {
        int[] a = new int[] {1, 2, 5, 4, 2, 0};
        int[] result = MergeSort(a, 0, a.Length-1);
        foreach(int x in result)
            Console.Write(x + ' ');
    }
    
    
    
    static void Merge(int[] a, int lowPoint, int middle, int farPoint)
    {
        int first = lowPoint;
        int second = middle + 1;
        int position = 0;
        int[] result = new int[farPoint - lowPoint + 1];
        
        while(first <= middle && second <= farPoint)
        {
            if(a[first] < a[second])
            {
               result[position] = a[first];
               first++;
            }  
            else
            {
                result[position] = a[second];
                second++;
            }
            position++;
        }
        for(int i = first; i <= middle; i++)
        {
           result[position] = a[first];
           position++;
        }
        for(int i = second; second <= farPoint; i++)
        {
            result[position] = a[second];
            position++;
        }
        for(int i = 0; i < a.Length; i++)
            a[lowPoint + i] = result[i];
    }
    static int[] MergeSort(int[] a, int low, int far)
    {
        if(low < far)
        {
           int mid = (far - low) / 2;
           MergeSort(a, low, mid);
           MergeSort(a, mid + 1, far);
           Merge(a, low, mid, far);
        }
        return a;
    }
}
