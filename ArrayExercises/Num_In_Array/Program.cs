namespace Num_In_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = { 42, 74, 3142, 451, 25, 96, 15, 776, 292, 1, 11, 52, 123, 14 };

            bool found = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == n)
                {

                    Console.WriteLine($"Числото се намира на {i} позиция.");
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("Числото не е намерено.");
            }
        }
    }
}
