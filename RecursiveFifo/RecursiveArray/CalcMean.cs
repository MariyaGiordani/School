using System;

namespace RecursiveArray
{

    // To find the mean of the elements of the array.
    // Mean = (Sum of elements of the Array) / (Total no of elements in Array)
    // Examples:
    // Input : 4 6 3 4 5
    // Output : 3

    class CalcMean
    {
        static float findMean(int[] A, int N)
        {
            if (N == 1)
            {
                return (float)A[N - 1];
            }
            else
            {
                return ((float)(findMean(A, N - 1) * (N - 1) + A[N - 1]) / N);
            }
        }

        public static void Main()
        {
            int[] A = { 4, 6, 3, 4, 5 };
            int N = A.Length;
            Console.WriteLine("Input : 4 6 3 4 5 ");
            Console.WriteLine("Mean = (Sum of elements of the Array) / (Total no of elements in Array)");
            float result = findMean(A, N);
            Console.WriteLine("Output : " + result);
            Console.ReadKey();
        }
    }
}
