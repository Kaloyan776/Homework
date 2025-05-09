namespace Zadacha5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[] list = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            BubbleSort(list);
            Console.WriteLine(list[0]);
            Console.WriteLine(list[list.Length - 1]);
        }
        static void BubbleSort(int[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                bool something = false;
                for (int j = 0; j < a.Length - 1 - i; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int swapNum = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = swapNum;
                        something = true;
                    }

                }
                if (!something)
                {
                    break;
                }
            }
            

        }
    }
}
