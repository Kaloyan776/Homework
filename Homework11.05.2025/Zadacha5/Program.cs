namespace Zadacha5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool Sorted = true;
            bool Unsorted = true;

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    Sorted = false;
                }
                if (array[i] < array[i + 1])
                {
                    Unsorted = false;
                }
            }

            if (Sorted)
            {
                Console.WriteLine("Масивът е във възходящ ред.");
            }
            else if (Unsorted)
            {
                Console.WriteLine("Масивът е в низходящ ред.");
            }
            else
            {
                Console.WriteLine("Масивът не е сортиран.");
            }

        }
    }
}
