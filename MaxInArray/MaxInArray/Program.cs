namespace MaxInArray
{
    using System;

    class Program
    {
        static void Main()
        {
            int[] intNumbers = { 5, 10, 3, 8, 1 };
            float[] floatNumbers = { 5.2f, 10.7f, 3.1f, 8.9f, 1.4f };
            string[] strings = { "apple", "banana", "cherry", "date", "elderberry" };

            int intMaximum = FindMaximum(intNumbers);
            float floatMaximum = FindMaximum(floatNumbers);
            string stringMaximum = FindMaximum(strings);

            Console.WriteLine("The maximum integer is: " + intMaximum);
            Console.WriteLine("The maximum float is: " + floatMaximum);
            Console.WriteLine("The maximum string is: " + stringMaximum);
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

        static string FindMaximum(string[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                throw new ArgumentException("The string array is empty or null.");
            }

            string maximum = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (string.Compare(arr[i], maximum) > 0)
                {
                    maximum = arr[i];
                }
            }

            return maximum;
        }
    }
}