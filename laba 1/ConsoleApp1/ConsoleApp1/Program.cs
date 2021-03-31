using System;

namespace ConsoleApplication1
{
    class Interface  //interface rendering class
    {
        public string Title;
        public string Query;
        public string[] face;
        public Interface()
        {
            Title = "Game: rock-paper-scissors";
            Query = "Press any key to replay the game or Esc to exit...";
            face = new string[21];
            face[0] = " -----------------------------------------------------------";
            face[1] = "|           Game: rock-paper-scissors                      |";
            face[2] = " -----------------------------------------------------------";
            face[3] = "| Enter a word: rock, scissors ,paper or well..                |";
            face[4] = "|            Your turn    vs     Computer                    |";
            face[5] = "|                                                            |";
            face[6] = "|                                                            |";
            face[7] = "|                                                            |";
            face[8] = "|                                                            |";
            face[9] = "|                                                            |";
            face[10] = "|                                                            |";
            face[11] = "|                                                            |";
            face[12] = "|                                                            |";
            face[13] = "|                                                            |";
            face[14] = "|                                                            |";
            face[15] = "|                                                            |";
            face[16] = "|                                                            |";
            face[17] = "|                                                            |";
            face[18] = " ------------------------------------------------------------";
            face[19] = "|                                                            |";
            face[20] = " ------------------------------------------------------------";
        }
        public void Draw()  //function to draw an empty field
        {
            Console.SetCursorPosition(0, 0);
            Console.Clear();
            for (int i = 0; i <= 20; i++)
            {
                Console.WriteLine(face[i]);
            };
        }
    }
    class Object
    {
        public string[] obj = { "rock", "scissors", "paper", "well" };
        public string user = null;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Interface iFace = new Interface();
            Console.Title = iFace.Title;
            Console.ForegroundColor = ConsoleColor.Red;
            ConsoleKeyInfo keyCode = new ConsoleKeyInfo(); //starting to process keystrokes
            Object game = new Object();
            while (keyCode.Key != ConsoleKey.Escape)
            {
                Console.Clear();
                iFace.Draw();
                Console.SetCursorPosition(13, 6);
                game.user = Console.ReadLine();
                Random rand = new Random();
                int i = rand.Next(4);
                Console.SetCursorPosition(33, 6);
                Console.Write(game.obj[i]);
                Console.SetCursorPosition(21, 10);
                switch (game.user)
                {
                    case "rock":
                        if (game.obj[i] == "rock")
                        {
                            Console.Write("Draw...");
                        }
                        if (game.obj[i] == "scissors")
                        {
                            Console.Write("You win..");
                        }
                        if (game.obj[i] == "paper")
                        {
                            Console.Write("You lose...");
                        }
                        if (game.obj[i] == "well")
                        {
                            Console.Write("You lose...");
                        }
                        break;
                    case "scissors":
                        if (game.obj[i] == "rock")
                        {
                            Console.Write("You lose...");
                        }
                        if (game.obj[i] == "scissors")
                        {
                            Console.Write("Draw..");
                        }
                        if (game.obj[i] == "paper")
                        {
                            Console.Write("You win...");
                        }
                        if (game.obj[i] == "well")
                        {
                            Console.Write("You lose...");
                        }
                        break;
                    case "paper":
                        if (game.obj[i] == "paper")
                        {
                            Console.Write("Draw...");
                        }
                        if (game.obj[i] == "scissors")
                        {
                            Console.Write("You lose...");
                        }
                        if (game.obj[i] == "rock")
                        {
                            Console.Write("You win...");
                        }
                        if (game.obj[i] == "well")
                        {
                            Console.Write("You win..");
                        }
                        break;
                    case "well":
                        if (game.obj[i] == "paper")
                        {
                            Console.Write("You lose..");
                        }
                        if (game.obj[i] == "scissors")
                        {
                            Console.Write("You win...");
                        }
                        if (game.obj[i] == "rock")
                        {
                            Console.Write("You win...");
                        }
                        if (game.obj[i] == "well")
                        {
                            Console.Write("Draw...");
                        }
                        break;
                    default:
                        {
                            Console.SetCursorPosition(7, 10);
                            Console.Write("You typed the wrong word. Try again.");
                        }
                        break;
                }
                Console.SetCursorPosition(3, 19);
                Console.WriteLine("Press any key to repeat. Еsc - exit");
                keyCode = Console.ReadKey(true);
            };
        }
    }
}
