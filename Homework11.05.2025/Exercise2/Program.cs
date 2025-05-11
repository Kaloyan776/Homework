namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int swapCount = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int swapNum = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = swapNum;
                        swapCount++;
                    }
                }
            }

            foreach (var k in array)
            {
                Console.Write(k);
            }
            Console.WriteLine("Брой размени: " + swapCount);

        }
    }
}
