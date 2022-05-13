public class Player {
    Deck deck;
    int score;
    int nextCard;
    int previousCard;

    // Set initial score, create instance on Deck and get a random card
    public Player() {
        this.score = 300;
        this.deck = new Deck();
        previousCard = this.deck.GetRandomNumber();
    }

    // While player chooses to continue playing, it will ask for the guess,
    // sum the according points and display them, and get another random card
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

    // Asks the user if he thinks the next card is higher or
    // lower than the previous
    public string cardDecision(string choice) {
        Console.Write("Higher or lower? [h/l]");
        choice = Console.ReadLine();

        return choice;
    }

    // Gets another random card and displays its value
    public int getNextCardAndShow(int nextcard) {
        nextCard = this.deck.GetRandomNumber();
        Console.WriteLine($"The card is: {nextCard}");

        return nextCard;
    }

    // Assigns the corresponding points based on the user's choice
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