namespace MaxInArray
{
    using System;

    class Program
    {
        static void Main()
        {
            float[] numbers = { 5.2f, 10.7f, 3.1f, 8.9f, 1.4f };

            float maximum = FindMaximum(numbers);
            Console.WriteLine("The maximum number is: " + maximum);
        }

        static float FindMaximum(float[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                throw new ArgumentException("The array is empty or null.");
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