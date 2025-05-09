namespace Zadacha4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int i = 0;

            while (i < list.Count - 1)
            {
                int j = 0;
                while (j < list.Count - 1)
                {
                    if (list[j] > list[j + 1])
                    {
                        int swapNum = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = swapNum;
                    }
                    j++;
                }
                i++;
            }



            foreach (int k in list)
            {
                Console.Write(k + " ");
            }
        }
    }
}
