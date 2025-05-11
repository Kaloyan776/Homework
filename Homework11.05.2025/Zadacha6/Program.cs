namespace Zadacha6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();


            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int swapNum = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = swapNum;
                    }
                }
            }

            int min = array[0];
            int max = array[array.Length - 1];
            int difference = max - min;

            Console.WriteLine("Сортиран масив: " + string.Join(", ", array));
            Console.WriteLine("Разлика между най-голям и най-малък елемент: " + difference);

        }
    }
}
