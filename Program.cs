namespace WordSearch
{
    internal class Program
    {
        public const int sizeX = 6;
        public const int sizeY = 27;

        /// <summary>
        /// The for loops in main makes the grid following the sixe parameters et by the two public ints
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            for (int i = 0; i < sizeX; i++)
            {
                for (int j = 0; j < sizeY; j++)
                {
                    Console.Write("x ");
                }

                Console.Write('\n');
            }
        }

    }
}
