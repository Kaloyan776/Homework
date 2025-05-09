namespace BubleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> {200, 93, 55, 12, 41, 89 };

            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = 0; j < list.Count - 1 - i; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        int swapNum = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = swapNum;

                    }
                }
            }

            foreach (var k in list)
            {
                Console.Write(k + " ");
            }


        }
    }
}
