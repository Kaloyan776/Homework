namespace Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            BubbleSort(array);
            Console.WriteLine("Сортиран масив: " + string.Join(", ", array));
            Console.WriteLine(array[0]);
            Console.WriteLine(array[array.Length - 1]);
        }
        static void BubbleSort(int[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                bool swapped = false;
                for (int j = 0; j < a.Length - 1 - i; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int swapNum = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = swapNum;
                        swapped = true;
                    }
                }

                if (!swapped)
                {
                    break;
                }
            }
        }
    }
}
