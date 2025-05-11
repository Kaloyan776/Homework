namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int i = 0;

            while (i < array.Length - 1)
            {
                int j = 0;
                while (j < array.Length - 1 - i)
                {
                    if (array[j] > array[j + 1])
                    {
                        int swapNum = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = swapNum;
                    }
                    j++;
                }
                i++;
            }

            Console.WriteLine("Сортиран масив: " + string.Join(", ", array));

        }
    }
}
