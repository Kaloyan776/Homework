namespace _02.MinAndMaxElementInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 42, 7, 31, 45, 25, 96, 15, 77, 29, 1, 11, 52, 123, 14 };
            int min = int.MaxValue;
            int max = int.MinValue;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            Console.WriteLine($"Min = {min}");
            Console.WriteLine($"Max = {max}");
        }
    }
}
