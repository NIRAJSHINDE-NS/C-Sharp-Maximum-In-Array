namespace MaxInArray
{
    using System;

    class Program
    {
        static void Main()
        {
            int[] intNumbers = { 5, 10, 3, 8, 1 };
            float[] floatNumbers = { 5.2f, 10.7f, 3.1f, 8.9f, 1.4f };

            int intMaximum = FindMaximum(intNumbers);
            float floatMaximum = FindMaximum(floatNumbers);

            Console.WriteLine("The maximum integer is: " + intMaximum);
            Console.WriteLine("The maximum float is: " + floatMaximum);
        }

        static int FindMaximum(int[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                throw new ArgumentException("The integer array is empty or null.");
            }

            int maximum = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > maximum)
                {
                    maximum = arr[i];
                }
            }

            return maximum;
        }

        static float FindMaximum(float[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                throw new ArgumentException("The float array is empty or null.");
            }

            float maximum = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > maximum)
                {
                    maximum = arr[i];
                }
            }

            return maximum;
        }
    }

}