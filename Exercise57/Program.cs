namespace Exercise57
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                string playerOne = GetUserHand("Player 1, enter rock(r), paper(p), or scissors(s): ");
                Hand playerOneHand = StringToEnum(playerOne);
                string playerTwo = GetUserHand("Player 2, enter rock(r), paper(p), or scissors(s): ");
                Hand playerTwoHand = StringToEnum(playerTwo);

                string result = DetermineWinner(playerOneHand,playerTwoHand);
                Console.WriteLine(result);

            } while (GetUserChoice("Would you like to continue (Y/N): ") == true);
            
        }

        static string DetermineWinner(Hand playerOne, Hand playerTwo)
        {
            if ((playerOne == Hand.Paper && playerTwo == Hand.Rock) || 
                (playerOne == Hand.Scissors && playerTwo == Hand.Paper) ||
                (playerOne == Hand.Rock && playerTwo == Hand.Scissors))
            {
                return "Player 1 wins!";
            }
            else if ((playerTwo == Hand.Paper && playerOne == Hand.Rock) ||
                (playerTwo == Hand.Scissors && playerOne == Hand.Paper) ||
                (playerTwo == Hand.Rock && playerOne == Hand.Scissors))
            {
                return "Player 2 wins";
            }

            return "Tie!!!";
        }
        static bool GetUserChoice(string message)
        {
            string userInput;

            do
            {
                Console.Write(message);
                userInput = Console.ReadLine().ToUpper().Trim();
            } while (userInput != "Y" && userInput != "N");

            return userInput == "Y";
        }
        static Hand StringToEnum(string player)
        {
            return player switch
            {
                "r" => Hand.Rock,
                "p" => Hand.Paper,
                "s" => Hand.Scissors,
                _ => Hand.None
            };
        }
        static string GetUserHand(string message)
        {
            string userChoice = string.Empty;
            bool isValidChoice = false;

            do
            {
                Console.Clear();
                Console.WriteLine(message);
                userChoice = Console.ReadLine().ToLower().Trim();

                isValidChoice = userChoice == "s" || userChoice == "p" || userChoice == "r";

            } while (!isValidChoice);

            return userChoice;
        }
    }
    public enum Hand
    {
        None,
        Rock,
        Paper,
        Scissors
    }
}
