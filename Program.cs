namespace Assignment_7._2._1_Implementing_Shell_Sort_Algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShellSort letsGo = new ShellSort();

            int[] arr = { 1, 4, 3, 8, 2, 5 };

            Console.Write("Array before sorting: \n");
            letsGo.Print(arr);

            letsGo.Sort(arr);

            Console.Write("\nArray after sorting : \n");
            letsGo.Print(arr);
        }
    }

    public class ShellSort
    {
        public int Sort(int[] arr)         // method to sort arr using ShellSort

        {
            int n = arr.Length;

            for (int gap = n / 2; gap > 0; gap /= 2)        // start with big gap, then reduce the gap
            {
                for (int i = gap; i < n; i++)       // do gapped insertion sort. keep adding one more element until the entire array is gap sorted
                {
                    int temp = arr[i];      // add a[i] to the elements that have been gap sorted. save a[i] in temp and make a hole at position i
                    int j;          

                    for (j = i; j >= gap && arr[j - gap] > temp; j -= gap)          // shirp earlier gap sorted elements up until the correct location for a[i] is found
                    {
                        arr[j] = arr[j - gap];
                    }

                    arr[j] = temp; // put temp (the original a[i]) in its correct location
                }

            }
            return 0; // can use public void instead of public int and omit return 0
        }

        public void Print(int[] arr)         // method to print array of size n
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

    }
}

