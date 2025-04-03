namespace EvenNumsInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 42, 74, 3142, 451, 25, 96, 15, 776, 292, 1, 11, 52, 123, 14 };
            int EvenNums = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    EvenNums++;
                }
            }

            Console.WriteLine(EvenNums);
        }
    }
}
