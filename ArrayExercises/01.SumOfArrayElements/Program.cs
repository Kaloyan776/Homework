namespace _01.SumOfArrayElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 42, 7, 31, 45, 25, 96, 15, 77, 29, 1, 11, 52, 123, 14};
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            Console.WriteLine(sum);
        }
    }
}
