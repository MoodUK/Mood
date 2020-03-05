using System;

namespace bubblesort
{
    class bubbleSort
    {
        static void Bubblesort(int[] Arr)
        {

            // get the length of the array as it might not be known for every instance.
            //int l = Arr.Length;
            int n = Arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (Arr[j+1] < Arr[j])
                    {

                        int temporary = Arr[j];
                        Arr[j] = Arr[j + 1];
                        Arr[j + 1] = temporary;

                    }
                }
            }
            
        }

        static void Print(int[] Arr)
        {
            int n = Arr.Length;
            for (int i = 0; i  < n; ++i)
            {
                Console.Write(Arr[i] + " ");
            }
            Console.WriteLine();
        }
        
        static void Main()
        {
            int[] Arr = { 1, 5, 4, 53, 5, 1, 2, 4, 5, 3, 2, 5, 9, 6, 4, 10001, 89 };
            Bubblesort(Arr);
            Print(Arr);
            
            
        }

    }
}
