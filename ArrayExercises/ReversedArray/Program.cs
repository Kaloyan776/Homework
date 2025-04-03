namespace ReversedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 42, 74, 3142, 451, 25, 96, 15, 776, 292, 1, 11, 52, 123, 14 };

            Console.WriteLine("Това е оригиналният масив:");
            foreach (int i in array)
            {
                Console.Write($"{i} ");
            }
            Array.Reverse(array);

            Console.WriteLine();
            Console.WriteLine("Това е обърнатият масив:");
            foreach (int i in array)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
