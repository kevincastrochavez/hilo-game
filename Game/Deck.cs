public class Deck {
    public int card;
    
    public Deck() {
    }

    // Generates random number from 1 to 13
    public int GetRandomNumber() {
        Random random = new Random();
        card = random.Next(1, 14);

        return card;
    }
}