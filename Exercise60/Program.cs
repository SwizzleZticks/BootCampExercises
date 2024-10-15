namespace Exercise60
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Deck aDeck = new Deck();
                aDeck.Shuffle();

                Console.WriteLine("Shuffling... You drew a " + aDeck.DrawCard().ToString());
            } while (GetUserChoice("Would you like to continue (Y/N)?"));
        }

        static bool GetUserChoice(string message)
        {
            string userInput;

            do
            {
                Console.Write(message);
                userInput = Console.ReadLine().ToUpper().Trim();
                Console.Clear();
            } while (userInput != "Y" && userInput != "N");

            return userInput == "Y";
        }
    }
}
