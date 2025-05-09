namespace Zadacha2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            for (int i = 0; i < list.Count - 1; i++)
            {
                bool something = false;
                for (int j = 0; j < list.Count - 1 - i; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        int swapNum = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = swapNum;
                        something = true;
                    }
                    
                }
                if (!something)
                {
                    break;
                }
            }

            foreach (int k in list)
            {
                Console.Write(k + " ");
            }



        }
    }
}
