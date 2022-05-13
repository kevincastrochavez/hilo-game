public class Player {
    int score;
    Deck deck;
    int previousCard;
    int nextCard;

    public Player() {
        this.score = 300;
        this.deck = new Deck();
        previousCard = this.deck.GetRandomNumber();
    }

    public void StartGame() {
        string choice = "";
        bool keepPlaying = true;

        while (keepPlaying) {
            Console.WriteLine($"The card was: {previousCard}");
            Console.Write("Higher or lower? [h/l]");
            choice = Console.ReadLine();

            nextCard = this.deck.GetRandomNumber();
            Console.WriteLine($"The card is: {nextCard}");

            if (choice == "h" && nextCard > previousCard) {
                score += 100;
            } else if (choice == "l" && nextCard < previousCard) {
                score += 100;
            } else if (choice == "h" && nextCard < previousCard) {
                score -= 75;
            } else if (choice == "l" && nextCard > previousCard) {
                score -= 75;
            }

            Console.WriteLine($"Your score is {score}");

            Console.WriteLine("Play again? [y/n]");
            string answer = Console.ReadLine();

            if (answer == "N" || answer == "n") {
                keepPlaying = false;
            }

            previousCard = nextCard;
        }
    }
}