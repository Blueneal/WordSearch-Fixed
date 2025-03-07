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
            MakeGrid();
            string? userInput;
            string[]? category;

            Console.WriteLine("Welcome to Word Search!");
            Console.WriteLine("Want to play? [Y]es or [N]o?");
            userInput = Console.ReadLine();
            if (userInput == "Y")
            {
                Console.WriteLine("Select a Category");
                Console.WriteLine("[D]ogs, [P]okemon, [S]tates, [L]anguages");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case 'D':
                        {
                            int userNumber = 0;
                            MakeGrid();
                            Console.WriteLine("Input a # for the Column");
                            userNumber= int.Parse(Console.ReadLine());
                            if (userNumber > sizeX || userNumber >= 0)
                            {
                                Console.WriteLine("Invalid input, try again");
                                
                            }
                            else
                            {
                                Console.WriteLine("Input a # for the row");

                                    
                            }
                            continue;
                        }

                    case 'P':
                        {

                        }
                }
            }

        }

        public static void MakeGrid()
        { 
            string[] alphabet = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            Random rnd = new Random();
            for (int row = 0; row < sizeX; row++)
            {
                for (int col = 0; col < sizeY; col++)
                {
                    Console.Write(alphabet[rnd.Next(alphabet.Length)] + " ");
                }

                Console.Write('\n');
            }
        }

    }
}
