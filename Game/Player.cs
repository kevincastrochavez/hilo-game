public class Player {
    Deck deck;
    int score;
    int nextCard;
    int previousCard;

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
            choice = this.cardDecision(choice);

            nextCard = this.getNextCardAndShow(nextCard);

            score = this.AssignPoints(choice, nextCard, previousCard);

            Console.WriteLine($"Your score is {score}");

            Console.WriteLine("Play again? [y/n]");
            string answer = Console.ReadLine();

            if (answer == "N" || answer == "n") {
                keepPlaying = false;
            }

            previousCard = nextCard;
        }
    }

    public string cardDecision(string choice) {
        Console.Write("Higher or lower? [h/l]");
        choice = Console.ReadLine();

        return choice;
    }

    public int getNextCardAndShow(int nextcard) {
        nextCard = this.deck.GetRandomNumber();
        Console.WriteLine($"The card is: {nextCard}");

        return nextCard;
    }

    public int AssignPoints(string choice, int nextCard, int previousCard) {
        if (choice == "h" && nextCard > previousCard) {
            score += 100;
        } else if (choice == "l" && nextCard < previousCard) {
            score += 100;
        } else if (choice == "h" && nextCard < previousCard) {
            score -= 75;
        } else if (choice == "l" && nextCard > previousCard) {
            score -= 75;
        }

        return score;
    }
}