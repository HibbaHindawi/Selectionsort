using System;
using System.Diagnostics;
namespace Selectionsort
{
    class Program
    {
        static void sort(int []arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++){
                int min_idx = i;
                for (int j = i + 1; j < n; j++){
                if (arr[j] < arr[min_idx]){
                    min_idx = j;
                    }
                } 
            int temp = arr[min_idx];
            arr[min_idx] = arr[i];
            arr[i] = temp;
        }
    }  
        static void printArray(int []arr)
        {
            int n = arr.Length;
            for (int i=0; i<n; ++i){
                Console.WriteLine(arr[i]);
            }
        }
        static void Main(string[] args)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            int[] arr = new int[8000];
            Random random = new Random();
            for(int i = 0; i < 8000; i++){
                arr[i] = random.Next(1, 101); //1 - 100, including 100
            }
            sort(arr);
            Console.WriteLine("iArray är sorterad");
            printArray(arr);
            watch.Stop();
            long ts = watch.ElapsedMilliseconds;
            Console.WriteLine("RunTime " + ts);
            Console.ReadKey();
        }
    }
}
