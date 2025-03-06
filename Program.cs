namespace WordSearch
{
    internal class Program : Words
    {
        public const int sizeX = 20;
        public const int sizeY = 20;
        
        /// <summary>
        /// The for loops in main makes the grid following the size parameters set by the two public int
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            string? userInput;
            string[]? category;
            bool isPlaying = false;

            Console.WriteLine("Welcome to Word Search!");
            Console.WriteLine("Want to play? [Y]es or [N]o?");
            userInput = Console.ReadLine();
            if (userInput == "Y")
            {
                isPlaying = true;
                Console.WriteLine("Select a Category");
            }


            MakeGrid();

            ReadFromFile();
        }

        public static void MakeGrid()
        {
            for (int i = 0; i < sizeX; i++)
            {
                for (int j = 0; j < sizeY; j++)
                {
                    Console.Write("X ");
                }

                Console.Write('\n');
            }
        }

    }
}
