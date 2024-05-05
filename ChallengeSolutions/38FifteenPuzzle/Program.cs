

namespace _38FifteenPuzzle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numberPool = (new int[16] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 0}).ToList();

            int[][] matrix = new int[4][];
            matrix[0] = new int[4];
            matrix[1] = new int[4];
            matrix[2] = new int[4];
            matrix[3] = new int[4];

            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    matrix[x][y] = GetDeleteRandom(numberPool);
                    Console.WriteLine(matrix[x][y]);
                }
            }
        }
        static int GetDeleteRandom(List<int> random)
        {
            Random r = new Random(); // optimize this so it doesn't instantiate a new random everytime
            int accessIndex = r.Next(0,random.Count);//gets random index from an always shortening list
            int result = random[accessIndex]; // getting the value at the random index
            random.RemoveAt(accessIndex);  // removes value at the random index

            return result;
        }
    }
}
